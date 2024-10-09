using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___55___Interface_Inheritance__
{
    interface i1
    {
        void p1();
    }

    interface i2
    {
        void p2();

    }

    // Interface inheritance chain
    interface i3 : i1 , i2
    {
        void p3();
    }
    class Program : i3
    {
        public void p3()
        {
            Console.WriteLine("I3 Method");
        }

        public void p1()
        {
            Console.WriteLine("I1 Method");
        }

        public void p2()
        {
            Console.WriteLine("I2 Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.p1();
            p.p2();
            p.p3();

            Console.WriteLine("After creating object of child class and refrence of parent interface");
            i3 Myint = new Program();
            Myint.p2();

        }
    }
}
