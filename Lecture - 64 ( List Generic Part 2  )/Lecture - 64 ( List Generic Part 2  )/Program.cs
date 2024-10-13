using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___64___List_Generic_Part_2___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Omkara");
            list.Add(null);
            list.Add("Rudra");
            list.Add("Mayank");
            

            foreach(string item in  list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\t');

            //Integer List
            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(212);
            list2.Add(3);

            //For Sorting
            list2.Sort();

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count of integer list is : " + list2.Count);

            Console.WriteLine('\t');


            //With the help of add range whole list add in single line
            //list2.AddRange(list2);

            //On particular element inserting new single element
            list2.Insert(0, 901);

            Console.WriteLine("After insertion");

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
