using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___61___Queue_Non_Generic__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myqu = new Queue();

            //Pushing elements in queue
            myqu.Enqueue(1);
            myqu.Enqueue("Rudra");
            myqu.Enqueue(100.10);

            //accessing elements from queue

            foreach (var item in myqu)
            {
                Console.WriteLine(item);
            }

            //Removing element
            Console.WriteLine(myqu.Dequeue());

        }
    }
}
