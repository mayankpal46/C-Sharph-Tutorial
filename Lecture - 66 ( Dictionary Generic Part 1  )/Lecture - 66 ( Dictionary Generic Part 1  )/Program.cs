using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___66___Dictionary_Generic_Part_1___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> newdic = new Dictionary<int,int>();
            newdic.Add(1, 44);
            newdic.Add(3, 219);

            //Accessing single value
            //Console.WriteLine(newdic[3]);

            //Accessing multiple values
            foreach(var item in newdic)
            {
                Console.WriteLine(item.Value);
            }


        }
    }
}
