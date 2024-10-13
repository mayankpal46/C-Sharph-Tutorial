using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___65___List_Generic_Part_3___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> newl = new List<int>();
            newl.Add(191);
            newl.Add(89);
            newl.Add(21);

            Console.WriteLine(newl.Contains(21));
            Console.WriteLine(newl.Contains(211));

        }
    }
}
