using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadState = System.Threading.ThreadState;

namespace M3MAP1
{
    public partial class Form1 : Form
    {
        private Thread Fibonacci;

        public Form1()
        {
            InitializeComponent();
            bn_Suspend.Enabled = false;
            bn_Proceed.Enabled = false;
            bn_StopGenNum.Enabled = false;
        }

        private async void bn_Start_Click(object sender, EventArgs e)
        {
            bn_Start.Enabled = false;
            tb_LowBound.Enabled = false;
            tb_UpperBound.Enabled = false;

            int min = 0; 
            int max = 0;

            if (tb_LowBound.Text.Length > 0)
            {
                min = int.Parse(tb_LowBound.Text);
            }

            if (tb_UpperBound.Text.Length > 0)
            {
                max= int.Parse(tb_UpperBound.Text);
            }

            await GenerateNumbers(min,max);
        }

        static readonly CancellationTokenSource CancelTokenSource = new CancellationTokenSource();
        CancellationToken token = CancelTokenSource.Token;

        static readonly CancellationTokenSource CancelTokenSource2 = new CancellationTokenSource();
        CancellationToken token2 = CancelTokenSource.Token;

        

        private Task GenerateNumbers(int lowB, int uppB)
        {
            return Task.Run(() =>
            {
                
                bool run = true;

                string str;
                while (run)
                {
                    
                    if (uppB != 0)
                        run = false;

                    int i = lowB;

                    if (lowB == 0)
                    { i = 2;}

                    int j = uppB;

                    if (j == 0)
                    { j = 10_000;}

                    while (i != j)
                    {
                        if (token.IsCancellationRequested)
                            return;
                        str = "";
                        int q = i + 10;
                        while (i != q && i < j)
                        {
                            str += i.ToString()+",";
                            ++i;
                        }

                        str += "\n\r";
                        
                        new Thread(() =>
                        {

                            Invoke(new Action(() => //UI Thread
                                {
                                    if (str != null) tb_ResultGen.Text += str;
                                }

                            ));

                        }).Start();

                        Thread.Sleep(1000);
                    }
                    
                }
                new Thread(() =>
                {

                    Invoke(new Action(() => //UI Thread
                        {
                            bn_Start.Enabled = true;
                            tb_LowBound.Enabled = true;
                            tb_UpperBound.Enabled = true;
                        }
                    ));

                }).Start();
            });
            
        }

        private void tb_LowBound_TextChanged(object sender, EventArgs e)
        {
            if (tb_LowBound.Text.Length > 0)
            {
                try
                {
                   int test = int.Parse(tb_LowBound.Text);
                   tb_LowBound.BackColor = Color.Bisque;
                }
                catch (Exception)
                {
                    tb_LowBound.BackColor = Color.Red;
                    bn_Start.Enabled = false;
                    return;
                }
            }
            else
            {
                tb_LowBound.BackColor= Color.AliceBlue;
            }
            bn_Start.Enabled = true;
        }

        private void tb_UpperBound_TextChanged(object sender, EventArgs e)
        {
            if (tb_UpperBound.Text.Length > 0)
            {
                try
                {
                    int test = int.Parse(tb_UpperBound.Text);
                    tb_UpperBound.BackColor = Color.Bisque;
                }
                catch (Exception)
                {
                    tb_UpperBound.BackColor = Color.Red;
                    bn_Start.Enabled = false;
                    return;
                }
            }
            else
            {
                tb_UpperBound.BackColor = Color.AliceBlue;
            }
            bn_Start.Enabled = true;
        }

        private void bn_StopGenNum_Click(object sender, EventArgs e)
        {
            CancelTokenSource.Cancel();
            bn_Start.Enabled = true;
            tb_LowBound.Enabled = true;
            tb_UpperBound.Enabled = true;
            
            
        }

        private void bt_StopCalc_Click(object sender, EventArgs e)
        {
            if (Fibonacci.IsAlive)
            {
                Fibonacci.Abort();
            }
            bn_Suspend.Enabled = false;
        }

        private void bn_Suspend_Click(object sender, EventArgs e)
        {

                Fibonacci.Suspend();
                bn_Suspend.Enabled = false;
                bn_Proceed.Enabled = true;
 
        }

        private void bn_Proceed_Click(object sender, EventArgs e)
        {

                Fibonacci.Resume();
                bn_Suspend.Enabled = true;
                bn_Proceed.Enabled = false;

        }

        private void bt_Restart_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tb_FibNum.Text);
            Fibonacci.Abort();
            ParameterizedThreadStart ts = new ParameterizedThreadStart(FibonacciTaskRun);
            Fibonacci = new Thread(ts);
            Fibonacci.Start((object)i);
            
        }

        void FibonacciTaskRun(object a)
        {

            string str = string.Empty;

            int n1 = 0, n2 = 1, n3, i, j=0, number=(int)a;
            str += n1.ToString() + "\n\r" + n2.ToString() + "\n\r";

            new Thread(() =>
            {

                Invoke(new Action(() => //UI Thread
                    {
                        tb_FibMonitor.Text += str;
                    }

                ));

            }).Start();
            for (i = 2; i < number; ++i)
            {
                str = "";
                n3 = n1 + n2;
                str += n3.ToString() + "\n\r";
                n1 = n2;
                n2 = n3;

                new Thread(() =>
                {

                    Invoke(new Action(() => //UI Thread
                        {
                            tb_FibMonitor.Text += str;
                        }

                    ));

                }).Start();
                Thread.Sleep(500);
            }
        }


        private void bn_StartFib_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tb_FibNum.Text);
            
            ParameterizedThreadStart ts = new ParameterizedThreadStart(FibonacciTaskRun);
            Fibonacci = new Thread(ts);
            Fibonacci.Start((object)i);
            bn_Suspend.Enabled = true;
            bn_Proceed.Enabled =false;
            bt_StopCalc.Enabled = true;
        }

        private void tb_FibNum_TextChanged(object sender, EventArgs e)
        {
            if (tb_UpperBound.Text.Length > 0)
            {
                try
                {
                    int test = int.Parse(tb_FibNum.Text);
                    tb_UpperBound.BackColor = Color.Bisque;
                }
                catch (Exception)
                {
                    tb_FibNum.BackColor = Color.Red;
                    bn_Start.Enabled = false;
                    bt_Restart.Enabled = false;
                    return;
                }
            }
            else
            {
                tb_UpperBound.BackColor = Color.AliceBlue;
            }
            bn_Start.Enabled = true;
            bt_Restart.Enabled = true;
        }
    }

    
}
