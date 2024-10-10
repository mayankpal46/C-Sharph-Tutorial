using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___59___HashTable_Part2__
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
            hashtable.Add(200, "Omkara");

            //Accessing all element through for loop
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(hashtable[key]);            
            }
            
            hashtable.Remove("a");
            Console.WriteLine('\t');
             
            Console.WriteLine("After Removing element");
            //After removing
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(hashtable[key]);
            }

            Console.WriteLine('\t');

        }
    }
}
