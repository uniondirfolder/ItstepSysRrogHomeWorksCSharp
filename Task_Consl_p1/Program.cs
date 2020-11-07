using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task_Consl_p1
{


    public class Program
    {
        static void Method()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.Write("{0} ",i);
            }

            Console.WriteLine();
        }
        static void ThreadFunk(object box)
        {
            int[] arr = (int[]) box;
            for (int i = arr[0]; i < arr[1]+1; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }

        private static void DoSomeWithObj(object o)
        {
            StateObject so = o as StateObject;
            if (so.task != null)
            {
                switch (so.task)
                {
                    case StateObject.Task.Fill:
                        so.FillArr();
                        break;
                    case StateObject.Task.Min:
                        Console.WriteLine(so.GetMin());
                        break;
                    case StateObject.Task.Max:
                        Console.WriteLine(so.GetMax());
                        break;
                    case StateObject.Task.Avg:
                        Console.WriteLine(so.GetAvg());
                        break;
                    case StateObject.Task.ToFile:
                        so.WriteToFile();
                        break;
                    default:
                        break;
                }
            }
        }

        public class StateObject
        {
            public enum Task
            {
                Fill,Max,Min,Avg,ToFile
            }
            public Task task { get; set; }
            public int Max { get; set; }
            public int Min { get; set; }
            public double Avg { get; set; }

            public List<int> rndInt = new List<int>();
            private Random rnd = new Random();

            private object sync = new object();

            public void FillArr()
            {
                lock (sync)
                {
                    if (rndInt.Count != 0)
                        rndInt.Clear();

                    for (int i = 0; i < 10000; i++)
                    {
                        rndInt.Add(rnd.Next(0, 10001));
                    }

                    GetMax();
                    GetMin();
                    GetAvg();
                }
            }

            public void WriteToFile()
            {
                lock (sync)
                {
                    File.AppendAllText("temp.txt", this.ToString());
                }
                
            }

            public int GetMax()
            {
                Max = -1;
                lock (sync)
                {
                    if (rndInt.Count != 0)
                    {
                        Max = rndInt.Max();
                    }
                }

                return Max;
            }
            public int GetMin()
            {
                Min = 10001;
                lock (sync)
                {
                    if (rndInt.Count != 0)
                    {
                        Min = rndInt.Min();
                    }
                }

                return Min;
            }
            public double GetAvg()
            {
                Avg = 0;
                lock (sync)
                {
                    if (rndInt.Count != 0)
                    {
                        Avg = rndInt.Average();
                    }
                }

                return Avg;
            }
            public override string ToString()
            {
                string str = string.Empty;
                for (int i = 0; i < rndInt.Count; i++)
                {
                    str += rndInt[i].ToString();
                }

                str += "\n\r";
                return $"Min - {Max} Max - {Min} Avg - {Avg}\n"+str;

            }
        }
        
        
        static void Main(string[] args)
        {
            Console.Write("Show count thread? (0 or 1 - select) >");
            string select = Console.ReadLine();

            ThreadStart threadPrint = new ThreadStart(Method);
            ParameterizedThreadStart threadPrintSe = new ParameterizedThreadStart(ThreadFunk);

            Thread thread = new Thread(threadPrint);
            Thread thread2 = new Thread(threadPrintSe);

            if (select == "1")
            {
                var prc = Process.GetCurrentProcess();
                Console.WriteLine("Count threads = " + prc.Threads.Count);
                var list = prc.Threads;
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"Thread id " + list[i].Id  + " state: " + list[i].ThreadState);
                }

            }

            thread.Start();
            Thread.Sleep(1000);

            Console.WriteLine("---------------");
            Console.WriteLine("Put start start/end bounds >");

            try
            {
                Console.Write("start > ");
                int start = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                Console.Write("end > ");
                int end = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                thread2.Start((object) new int[] {start,end });
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            if (select == "1")
            {
                var prc = Process.GetCurrentProcess();
                Console.WriteLine("Count threads = " + prc.Threads.Count);
                var list = prc.Threads;
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"Thread id " + list[i].Id + " state: " + list[i].ThreadState);
                }

            }
            Console.WriteLine("---------------");



            Console.WriteLine("---------------");
            StateObject state = new StateObject();
            state.FillArr();
            Console.WriteLine(state.GetAvg());
            
            Console.WriteLine("---------------");

            Random rndObjState = new Random();
            for (int i = 0; i < 100; i++)
            {
                state.task = (StateObject.Task) rndObjState.Next(0, 4);
                new Thread(DoSomeWithObj).Start(state);
                state.task = StateObject.Task.ToFile;
                new Thread(DoSomeWithObj).Start(state);
            }

            Console.ReadKey();
        }


    }


}

//Задание 1
//Создайте консольное приложение, порождающее
//поток. Этот поток должен отображать в консоль числа
//от 0 до 50.

//Задание 2
//Добавьте в первое задание возможность передачи
//начала и конца диапазона чисел. Границы определяет
//пользователь.

//Задание 3
//Добавьте к первому заданию возможность определения
//пользователем количества потоков. Границы диапазона
//чисел также выбираются пользователем.

//Задание 4
//Консольное приложение генерирует набор чисел,
//состоящий из 10000 элементов. С помощью механизма
//потоков нужно найти максимум, минимум, среднее в этом
//наборе.
//Для каждой из задач выделите поток.

//Задание 5
//К четвертому заданию добавьте поток, выводящий
//набор чисел и результаты вычислений в файл.
