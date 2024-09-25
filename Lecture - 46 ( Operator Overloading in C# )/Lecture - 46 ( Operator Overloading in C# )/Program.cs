using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___46___Operator_Overloading_in_C___
{
    class A
    {
        public int no;
        public string name;

        public static A operator +(A obj1 , A obj2)
        {
            A obj = new A();
            obj.no = obj1.no + obj2.no;
            return obj;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.no = 1;
            obj.name = "test";

            A obj1 = new A();
            obj1.no = 2;
            obj1.name = "test2";

            A fobj = new A();

            //This will call + function
            fobj = obj + obj1;
            Console.WriteLine(fobj.no );

        }
    }
}
