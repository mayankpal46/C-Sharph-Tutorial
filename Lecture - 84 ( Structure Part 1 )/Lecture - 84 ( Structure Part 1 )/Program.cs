using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___84___Structure_Part_1__
{
    internal struct Program
    {
        public void m1()
        {
            Console.WriteLine("Method 1");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.m1();
        }
    }
}
