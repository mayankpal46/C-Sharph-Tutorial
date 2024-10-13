using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___73___Try_With_Multiple_Catch__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 0;
            

            try
            {
                int c = a / b;

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
