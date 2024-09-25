using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___51___Sealed_Methods___
{
    class A
    {
        public virtual void M1()
        {
            Console.WriteLine("Method 1");
        }
    }

    class B : A
    {
        public sealed override void M1()
        {
            Console.WriteLine("Method 2");
        }
    }

    class C : B
    {
        //public override void M1()
        //{
        //    Console.WriteLine("Method 3");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.M1();

            Console.ReadLine();
        }
    }
}
