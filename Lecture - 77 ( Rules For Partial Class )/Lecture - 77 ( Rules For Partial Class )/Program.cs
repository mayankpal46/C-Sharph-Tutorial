using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___77___Rules_For_Partial_Class__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of partial class
            c1 obj = new c1();
            obj.m1();
        }
    }

    public class mclass
    {
        public void m1()
        {
            Console.WriteLine("My method");
        }
    }
}
