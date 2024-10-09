using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___56___Implementation_Interface__
{
    interface i1
    {
        void m1();
    }

    interface i2
    {
        void m1();
    }

    class A : i1 , i2
    {
        //Explicit Implementation
        void i1.m1()
        {
            Console.WriteLine("Interface i1 Method");
        }

        void i2.m1()
        {
            Console.WriteLine("Interface i2 Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            
            //During calling method which is in interface 
            
            ((i1)obj).m1();
        }
    }
}
