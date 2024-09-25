using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___50___Sealed_class___
{
    //sealed class A
    //{
    //    public void M1()
    //    {
    //        Console.WriteLine("Method 1");
    //    }
    //}

    class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }
    }
    class B : A
    {
        public void M2()
        {
            Console.WriteLine("Method 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.M1();

            Console.ReadLine();
        }
    }
}
