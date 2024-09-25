using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___47___Method_Hiding__
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }
    }

    class B : A
    {
        // used new keyword because it hides method of parent class
        public new void M1()
        {
            Console.WriteLine("Method 2");
        }

        public new void M2()
        {
            base.M1();
        }

        public void M3() 
        {
            base.M1();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.M1();

            //when use base keword
            obj.M2();

             
            A obj2 = new B();
            obj2.M1();
            
        }
    }
}
