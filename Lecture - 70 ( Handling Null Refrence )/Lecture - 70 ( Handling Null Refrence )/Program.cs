using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___70___Handling_Null_Refrence__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Omkara";
            Console.WriteLine("Length is : " + name.Length);

            string naam = null;
            try
            {
                Console.WriteLine(naam.Length);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
