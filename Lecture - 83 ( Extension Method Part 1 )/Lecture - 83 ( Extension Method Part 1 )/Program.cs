using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___83___Extension_Method_Part_1__
{
    internal class Program
    {
        public void m1()
        {
            Console.WriteLine("Method 1");
        }

        public void m2()
        {
            Console.WriteLine("Method 2");
        }
        public void m3()
        {
            Console.WriteLine("Method 3");
        }
        public void m4()
        {
            Console.WriteLine("Method 4");
        }
        public void m5()
        {
            Console.WriteLine("Method 5");
        }
        public void m8()
        {
            Console.WriteLine("Method 8 of Program class");

        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.m1();
            ob.m2();
            ob.m3();
            ob.m4();
            ob.m5();

            

        }
    }
}
