using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture___82___Multithreading_Part_2__
{
    internal class Program
    {
        public static void m1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 1 " + i);
            }
        }

        public static void m2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2 " + i);
                if (i == 7)
                {
                    //Console.WriteLine("SLeep mode starts");
                    //Go into sleep for 8000 seconds
                    //Thread.Sleep(9000);
                }
            }
        }

        public static void m3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 3 " + i);
            }
        }

        static void Main(string[] args)
        {
            //For single
            //Thread t = Thread.CurrentThread;
            //t.Name = "My Thread";

            //Console.WriteLine("Current Thread is : " + Thread.CurrentThread.Name);

            //Program.m1();
            //Program.m2();
            //Program.m3();

            //All these thread all child class of main thread 
            // main thread automatically create one our applications starts
            Thread t1 = new Thread(m1);
            Thread t2 = new Thread(m2);
            Thread t3 = new Thread(m3);

            t1.Start();
            t2.Start();

        }
    }
}
