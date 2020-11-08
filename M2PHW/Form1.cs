using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace M2PHW
{
    public partial class Form1 : Form
    {
        List<Process> Processes = new List<Process>();
    
        public Form1()
        {
            InitializeComponent();

        }

        private void button_Calc_Task_3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.FileName = label_Path_file.Text;
            pi.Arguments = $"{nud_Left.Text} {nud_Left.Text} {cb_OPeration.Items[cb_OPeration.SelectedIndex]}";
            pi.CreateNoWindow = true;
            var res = Process.Start(pi);
            int wait = 10_000;
            while (!res.HasExited)
            {
                Thread.Sleep(500);
                wait -= 1000;
                if (wait == 0) { res.Kill();}
            }
            int qq = res.ExitCode;
            label_Res_Task_3.Text = qq.ToString();

        }

        private void button_Task_2_Start_Click(object sender, EventArgs e)
        {
            ProcessStartInfo child = new ProcessStartInfo();
            button_Task_2_Start.Enabled=false;
            textBox_Path_Task_2.Enabled = false;
            button_Kill_Task_2.Enabled = true;
            child.FileName = textBox_Path_Task_2.Text;
            var toAdd =Process.Start(child);
            Processes.Add(toAdd);
            timer1.Start();
        }

        private void button_Kill_Task_2_Click(object sender, EventArgs e)
        {
            if (!Processes[0].HasExited)
            {
                Processes[0].Kill();
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Processes[0].HasExited)
            {
                label_Codend_Task_2.Text = Processes[0].ExitCode.ToString();
                Processes.Clear();
                timer1.Stop();
                button_Task_2_Start.Enabled = true;
                textBox_Path_Task_2.Enabled = true;
                button_Kill_Task_2.Enabled = false;
            }
        }

        private void button_Task_4_Go_Click(object sender, EventArgs e)
        {
            if (textBox_Task_4_Word.Text.Length > 0 && textBox_Task_4_FilePath.Text.Length > 0 &&
                File.Exists(textBox_Task_4_FilePath.Text) && Path.GetExtension(textBox_Task_4_FilePath.Text) == ".txt")
            {
                ProcessStartInfo pi = new ProcessStartInfo();
                pi.FileName = label_Ttask_4_Proga.Text;
                pi.Arguments = $"{textBox_Task_4_FilePath.Text} {textBox_Task_4_Word.Text}";
                
                var res = Process.Start(pi);
                int wait = 10_000;
                while (!res.HasExited)
                {
                    Thread.Sleep(500);
                    wait -= 1000;
                    if (wait == 0) { res.Kill();
                        MessageBox.Show(@"Soo long time pro killed!");
                    }
                }
                int qq = res.ExitCode;
                label_Task_4_Find.Text = qq.ToString();
            }
            else
            {
                MessageBox.Show(@"Wrong param!");
            }
        }

        private void button_Task_1_Start_Click(object sender, EventArgs e)
        {
            ProcessStartInfo child = new ProcessStartInfo("calc.exe");
            button_Task_1_Start.Enabled = false;
            
            var toAdd = Process.Start(child);
            Processes.Add(toAdd);
            while (!Processes[0].HasExited)
            {

            }

            label_Task_1_End.Text = Processes[0].ExitCode.ToString();
            Processes.Clear();
            button_Task_1_Start.Enabled = true;
        }
    }
}


//Задание 1
//Разработайте приложение, которое умеет запускать
//дочерний процесс и ожидать его завершения. Когда дочерний процесс завершен, родительское приложение
//должно отобразить код завершения.

//Задание 2
//Разработайте приложение, которое умеет запускать
//дочерний процесс. В зависимости от выбора пользователя
//родительское приложение должно ожидать завершения
//дочернего процесса и отображать код завершения либо
//принудительно завершать работу дочернего процесса.

//Задание 3
//Разработайте приложение, которое умеет запускать
//дочерний процесс и передавать ему аргументы командной
//строки. В качестве аргументов должно быть два числа
//и операция, которую необходимо выполнить. Например,
//аргументы:
//■ 7;
//■ 3;
//■ +.
//Дочерний процесс должен отобразить аргументы
//и вывести результат сложения 10 на экран.

//Задание 4
//Разработайте приложение, которое умеет запускать
//дочерний процесс и передавать ему аргументы командной
//строки. В качестве аргументов должны быть путь к файлу
//и слово для поиска. Например, аргументы:
//■ E:\someFolder;
//■ bicycle.
//Дочерний процесс должен отобразить количество раз,
//сколько слово bicycle встречается в файле.