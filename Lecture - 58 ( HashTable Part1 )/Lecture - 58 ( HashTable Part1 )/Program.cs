using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___58___HashTable_Part1__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Syntax 1
            Hashtable hashtable = new Hashtable();

            //Add is just a method
            hashtable.Add("a", 1);
            hashtable.Add("b", "Rudra");


            //Syntax 2

            Hashtable hashtable2 = new Hashtable()
            {
                {"d",32},
                {"f","Omkara"}
            };

            //Accessing value which store on that particular key
            Console.WriteLine(hashtable["b"]);
        }
    }
}
