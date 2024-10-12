using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___60___Stack_Non_Generic__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myst = new Stack();
            
            //Pushing value in stack
            myst.Push(1);
            myst.Push("Rudra");
            myst.Push(10.101);
            myst.Push(true);

            //Accessing elemnts of stack
            foreach(var item in myst)
            {
                Console.WriteLine(item);
            }


        }
    }
}
