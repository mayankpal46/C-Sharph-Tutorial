using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___40___Access_Specifier___Part_1____
{
    public class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }

        public void M3()
        {
            A obj1 = new A();
            obj1.M1();
        }
        void M2() 
        {
            Console.WriteLine("Private Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class which is public
             A obj = new A();
             obj.M1();
            obj.M3();
            
        }
    }
}
