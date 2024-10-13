using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___74___Finally_With_Try_Catch__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 100;
                int b = 0;
                int c = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //This will execute whether error occurs or not 
            finally
            {
                Console.WriteLine("Finally blocke execute ho gaya");
            }
        }
    }
}
