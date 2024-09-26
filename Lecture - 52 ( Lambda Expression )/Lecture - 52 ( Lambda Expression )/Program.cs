using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___52___Lambda_Expression__
{
    public delegate void mydelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            //mydelegate obj = delegate (int num) 
            //{
            //    num += 192;
            //    Console.WriteLine(num);
            //};


            //This will call anonymous function
            //obj.Invoke(19);

            //Lambda Expression
            //=> lambda operator
            //Statement Lambda
            mydelegate obj = (num) =>
            {
                num += 1;
                Console.WriteLine(num);
            };
            obj.Invoke(100);

            //Expression lambda
            //mydelegate obj2 = (num) => num*num;
            //obj2.Invoke(100);


        }
    }
}
