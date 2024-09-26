using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___51___Anonymouse_Function__
{
    //Declaring delegate
    //Delegate will point only to that method which contains same param and return type
    public delegate void mydelegate(int num);
        
    internal class Program
    {
        public static void M1(mydelegate del , int x)
        {
            x += 102;
            del.Invoke(x);
        }



        static void Main(string[] args)
        {
            // We are callling our static method with the help of object of our delegate
            //mydelegate obj = new mydelegate(Program.M1);
            //obj.Invoke(43);

            //mydelegate obj = delegate (int a)
            //{
            //    a += 100;
            //    Console.WriteLine(a);
            //};

            //Calling anonymous function
            //obj(5);

           


        }
    }
}  
