using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___79___String_And_StringBuilder__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Rudra";
            string s2 = "Omkara";
            s1 = s1 + s2;
            Console.WriteLine(s1);


            //StringBuilder

            StringBuilder obj = new StringBuilder("Shivayee");
            obj.Append(" Oberoi");

            Console.WriteLine(obj);
        }
    }
}
