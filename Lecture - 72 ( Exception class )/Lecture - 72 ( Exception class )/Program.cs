using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___72___Exception_class__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            try
            {
                Console.WriteLine(s.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
