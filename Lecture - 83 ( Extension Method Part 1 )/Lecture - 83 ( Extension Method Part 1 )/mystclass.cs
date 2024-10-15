using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___83___Extension_Method_Part_1__
{
    static class mystclass
    {
        //Its a extension method , which will going to belongs with program class
        // ( this Program p ) which is binding paramter , which belongs function m6 with program class
        public static void m6(this Program p)
        {
            Console.WriteLine("Method 6");
        }

        public static void m7(this Program d)
        {
            Console.WriteLine("Method 7");

        }

        public static void m8(this Program d)
        {
            Console.WriteLine("Method 8");

        }
    }
}
