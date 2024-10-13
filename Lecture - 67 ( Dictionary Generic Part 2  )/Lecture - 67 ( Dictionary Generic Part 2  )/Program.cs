using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___67___Dictionary_Generic_Part_2___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> newdic = new Dictionary<int, int>();
            newdic.Add(1, 1);
            newdic.Add(2, 912);
            newdic.Add(3, 302);
            newdic.Add(4, 822);

            //Simple count without condition
            Console.WriteLine(newdic.Count);

            //After filtering
            Console.WriteLine("Count After filter is : " + newdic.Count(s=>s.Value == 912));
                
        }
    }
}
