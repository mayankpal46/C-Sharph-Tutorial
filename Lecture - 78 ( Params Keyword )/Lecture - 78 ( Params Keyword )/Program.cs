using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___78___Params_Keyword__
{
    internal class Program
    {
        //Using params keyword in which we can pass any numbers of element

        //In a first element will pass and remaining element will pass into nums

        //In nums we are passing element one by one not a single array
        public static int Add(int a , params int[] nums)
        {
            int sum = 0;
            foreach(var item in  nums)
            {
                sum += item;
            }
            return sum;
        }

        //Here length of nums is 0
        public static void m1(params int[] nums)
        {
            Console.WriteLine("Method 1");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two numbers is : " + Program.Add(3, 4));

            //one by one number will pass in nums

            Console.WriteLine("Sum of Three numbers is : " + Program.Add(3 , 4 , 3));

            Program.m1();
           


        }
    }
}
