using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___75___Throw_Keyword__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 0;
            
            //Here exception will throw by default and catch by default
            int c = a / b;

            try
            {
                //Here exception will by c# and catch by us
                c = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Number de be");
            int num = int.Parse(Console.ReadLine());
            if (num == 100)
            {
                Console.WriteLine("Number equal hai");
            }
            else
            {
                throw new Exception("Number equal nahi hai");
            }




        }
    }
}
