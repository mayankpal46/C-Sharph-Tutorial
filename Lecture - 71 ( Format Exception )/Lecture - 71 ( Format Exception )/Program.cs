using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___71___Format_Exception__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number de be");
            string number = Console.ReadLine();

            try
            {
                //It will give an error if input is not a number , but it's a string format
                int num = int.Parse(number);
                Console.WriteLine("Number likh : " + num);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
