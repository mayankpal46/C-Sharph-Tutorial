using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___57___Multiple_Inehritance__
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }

        public void M2()
        {
            Console.WriteLine("Method of Class A");
        }
    }

    interface B
    {
        void M2();
    }

    // Multiple Inheritance
    class C : A , B
    {
        void B.M2()
        {
            Console.WriteLine("Method of Interface");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.M1();
            obj.M2();

            //Casting :- To call method which is present in interface 
            ((B)obj).M2();
        }
    }
}
