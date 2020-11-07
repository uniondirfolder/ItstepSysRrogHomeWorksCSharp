using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Task_1_2_3
{
    public partial class MainForm : Form
    {
        private static Timer _timer;
        public MainForm()
        {
            InitializeComponent();

            comboBox_RunManual.Sorted = true;

            var toComboAdd = Directory.GetFiles(@"C:\Windows\System32\");
            foreach (var i in toComboAdd)
            {
                if (Path.GetExtension(i)==".exe")
                {
                    comboBox_RunManual.Items.Add(Path.GetFileName(i));
                }
            }

            comboBox_RunManual.Items.Add("*.exe");
            textBox_Path.Enabled = true;
        }

        private void button_StartMonitorProc_Click(object sender, EventArgs e)
        {
            var prog = comboBox_RunManual.Items[comboBox_RunManual.SelectedIndex];

            try
            {
                if (prog == "*.exe")
                {
                    Process.Start(textBox_Path.Text);
                }
                else
                {
                    Process.Start(@"C:\Windows\System32\"+prog);
                }

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }


        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            new Thread(() =>
                {

                        Invoke(new Action(() => //UI Thread
                            {
                                button_StopProcListMonitoring.Enabled = false;

                                listView_Processes.Items.Clear();
                                Process[] procList = Process.GetProcesses();

                                foreach (Process process in procList)
                                {
                                    try
                                    {

                                        string[] processdetails =
                                        {
                                            process.ProcessName,
                                            process.Id.ToString(),
                                            process.StartTime.ToShortTimeString(),
                                            process.TotalProcessorTime.Milliseconds.ToString(),
                                            process.HandleCount.ToString(),
                                            process.Threads.Count.ToString()
                                        };
                                        ListViewItem item = new ListViewItem(processdetails);
                                        listView_Processes.Items.Add(item);
                                    }
                                    catch (Exception exception)
                                    {
                                        string[] processdetails = {
                                            process.ProcessName+$" <{exception.Message}>",
                                            "---",
                                            "---",
                                            "---",
                                            "---",
                                            "---"
                                        };
                                        ListViewItem item = new ListViewItem(processdetails);
                                        listView_Processes.Items.Add(item);
                                    }
                                }

                                listView_Processes.Sorting = SortOrder.Ascending;
                                listView_Processes.Sort();

                                button_StopProcListMonitoring.Enabled = true;
                            }
                        ));

                }).Start();
        }

        private void button_StopProcListMonitoring_Click(object sender, EventArgs e)
        {
            try
            {
                for (int j = 0; j < listView_Processes.Items.Count; j++)
                {
                    if (listView_Processes.Items[j].Selected && listView_Processes.Items[j].SubItems[1].Text != @"---")
                    {
                        try
                        {
                            var proc = Process.GetProcessById(int.Parse(listView_Processes.Items[j].SubItems[1].Text));
                            proc.Kill();
                            TimerOnElapsed(sender, null);
                            MessageBox.Show(@"Kill process ok!");
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _timer = new Timer((double.Parse(numericUpDown_UpdateInterval.Value.ToString())) * 1000);
            _timer.Elapsed += TimerOnElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();

            TimerOnElapsed(sender, null);
            comboBox_RunManual.SelectedIndex = 0;
            textBox_Path.Enabled = false;
           
            
        }

        private void comboBox_RunManual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_RunManual.Items[comboBox_RunManual.SelectedIndex] == "*.exe")
            {
                textBox_Path.Enabled = true;
                textBox_Path.Text = @"Put full path...*.exe";
            }
            else
            {
                textBox_Path.Enabled = false;
                textBox_Path.Text = "";
            }
        }
    }
}
