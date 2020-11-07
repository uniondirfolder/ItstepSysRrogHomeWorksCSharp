using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_WinForm_p1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Task_1_Click(object sender, EventArgs e)
        {
            ThreadStart threadPrint = new ThreadStart(Method);
            Thread thread = new Thread(threadPrint);
            thread.Start();
        }

        private void Method()
        {
            new Thread(() =>
            {
                Invoke(new Action(() => //UI Thread
                {
                    textBox_Task_1.Text = "";
                    for (int i = (int)numericUpDown_Task_2_Min.Value; i < (int)numericUpDown_Task2_Max.Value+1; i++)
                    {
                        textBox_Task_1.Text += i.ToString()+"\r\n";
                    }
                }
                ));

            }).Start();
            
        }

        private void button_Task_2_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart threadPrintSe = new ParameterizedThreadStart(ThreadFunk);
            Thread thread2 = new Thread(threadPrintSe);
            thread2.Start((object)new int[] { (int)numericUpDown_Task_2_Min.Value, (int)numericUpDown_Task2_Max.Value });
        }

        private void ThreadFunk(object obj)
        {
            new Thread(() =>
            {
                Invoke(new Action(() => //UI Thread
                    {
                        textBox_Task_2.Text = "";
                        int[] arr = (int[])obj;
                        for (int i = arr[0]; i < arr[1] + 1; i++)
                        {
                            textBox_Task_2.Text += i.ToString() + "\r\n";
                        }
                    }
                ));

            }).Start();
            
        }

        private void button_Task_4_Click(object sender, EventArgs e)
        {
            
            new Thread(() =>
            {
                
                Invoke(new Action(() => //UI Thread
                    {
                        Task_Consl_p1.Program.StateObject state = new Task_Consl_p1.Program.StateObject();
                        state.FillArr();
                        textBox_Task_4.Text = "";
                        button_Task_4.Enabled = false;
                        textBox_Task_4.Text = state.ToString();
                        label_Min.Text = "Min= " + state.GetMin().ToString();
                        label_Max.Text = "Max= " + state.Max.ToString();
                        label_Avg.Text = "Avg= " + state.Avg.ToString();
                        checkBox_Task_5_CheckedChanged(sender, e);
                        button_Task_4.Enabled = true;
                    }
                ));

            }).Start();
            

            
        }

        private void checkBox_Task_3_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Task_3.Text = "";
            if (checkBox_Task_3.Checked == true)
            {
                new Thread(() =>
                {
                    Invoke(new Action(() => //UI Thread
                        {
                            var prc = Process.GetCurrentProcess();
                            textBox_Task_3.Text +=("Count threads = " + prc.Threads.Count+"\r\n");
                            var list = prc.Threads;
                            for (int i = 0; i < list.Count; i++)
                            {
                                textBox_Task_3.Text += ($"Thread id " + list[i].Id + " state: " + list[i].ThreadState+"\r\n");
                            }
                        }
                    ));

                }).Start();
            }
        }

        private void checkBox_Task_5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Task_5.Checked == true)
            {
                if (textBox_Task_4.Text.Length > 0)
                {
                    File.AppendAllText("temp.txt", textBox_Task_4.Text);
                }
            }
        }
    }
}
