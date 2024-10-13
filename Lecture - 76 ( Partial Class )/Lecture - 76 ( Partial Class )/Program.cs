using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___76___Partial_Class__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myc obj = new myc();
            obj.Ageprop = 100;
            obj.Nameprop = "Rudra";
            Console.WriteLine(obj.m1()); ;
        }
    }
}
