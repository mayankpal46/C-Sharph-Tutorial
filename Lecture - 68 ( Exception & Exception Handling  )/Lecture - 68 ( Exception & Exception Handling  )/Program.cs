using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___68___Exception___Exception_Handling___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int no1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int no2 = int.Parse(Console.ReadLine());

            int num = 0;

            try
            {
                num = no1 / no2;
                Console.WriteLine("Result is : " + num);
            }

            // ex is a rerfrence variable of class dividebyzeroexception
            catch(DivideByZeroException ex)
            {
                //It will print error message
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Number can not divide by zero"); ;
            }

            
            Console.WriteLine("Statement 1");


            Console.WriteLine('\t');
        }
    }
}
