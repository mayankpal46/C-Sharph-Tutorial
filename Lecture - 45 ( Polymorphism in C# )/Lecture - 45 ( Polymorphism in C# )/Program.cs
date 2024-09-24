using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___45___Polymorphism_in_C___
{
    internal class Program
    {
        //Here we are doing method overloading
        public void M1()
        {
            int no = 1000;
            int num = 323;
            Console.WriteLine(no+num);
        }

        public void M1(string s)
        {
            
            Console.WriteLine("Method Overloading");
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.M1();

            //Calling parameterise method
            p.M1("Myname");

        }
    }
}
