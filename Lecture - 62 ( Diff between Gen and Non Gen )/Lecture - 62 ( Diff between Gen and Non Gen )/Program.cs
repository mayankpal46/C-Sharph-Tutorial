using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___62___Diff_between_Gen_and_Non_Gen__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[4];
            arr[0] = 100;
           
            //arr[4] = 213;
            //This will give index out of range exception
            //Console.WriteLine(arr[4]);

            //ArrayList which is Non-Generic
            ArrayList ob = new ArrayList();
            ob.Add(100);
            ob.Add("Rudra");
            ob.Add(100.191);

            //Accessing elements of arraylist
            foreach(object item in  ob)
            {
                Console.WriteLine(item);
            }

            //Generic Collection
            List<int> no = new List<int>();
            no.Add(100);
            no.Add(291);
            no.Add(21);
            no.Add(81);

            Console.WriteLine("Capacity of list is : " + no.Capacity);

            //This will give an error because we are trying to add string in integer type list
            //no.Add("Omkara");

            no.Add(00);
            no.Add(1011);

            //Capacity will always double value of its previous value
            Console.WriteLine("After adding two more values capacity of list is : " + no.Capacity);

            foreach(var item in no)
            {
                Console.WriteLine(item);
            }

        }
    }
}
