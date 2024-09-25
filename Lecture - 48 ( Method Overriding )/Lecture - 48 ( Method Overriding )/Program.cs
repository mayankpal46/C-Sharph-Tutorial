using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___48___Method_Overriding__
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }

        //virtual 
        public virtual void M2()
        {
            Console.WriteLine("Virtual Method");
        }
    }

    class B : A
    {
        // In case of method hiding
        public new void M1()
        {
            base.M1();
            Console.WriteLine("Method2");
        }

        //It allows to override
        public override void M2()
        {
            base.M2();
            Console.WriteLine("Child class Method");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.M2();

        }
    }
}
