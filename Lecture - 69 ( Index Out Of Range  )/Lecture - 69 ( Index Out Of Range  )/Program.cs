using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___69___Index_Out_Of_Range___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newarray = new int[5];
           

            try
            {
                newarray[0] = 1;
                newarray[1] = 221;
                newarray[2] = 13;
                newarray[3] = 434;
                newarray[4] = 35;
                
                //This will give an error indexout of range exception
                newarray[5] = 96;

                foreach (var item in  newarray)
                {
                    Console.WriteLine(item);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Statement 1");
        }
    }
}
