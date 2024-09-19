using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___35___Methods_Or_Functions___Part_2____
{
    internal class Program
    {
        public static void M1(string name="Unkown" , int age=10)
        {
            Console.WriteLine(name + " : " + age);
        }

        public static int IntValue(int no)
        {
            return no;
        }
        static void Main(string[] args)
        {
            Program.M1("dev", 20);

            //If location of parameter change
            Program.M1(age: 21, name: "omkara");

            int num = Program.IntValue(100);
            Console.WriteLine("Input no is : " + num);





            Console.ReadLine();
        }


    }
}
