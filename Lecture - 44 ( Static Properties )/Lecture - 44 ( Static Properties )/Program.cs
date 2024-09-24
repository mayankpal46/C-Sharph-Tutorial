using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___44___Static_Properties__
{
    class A
    {
        private static int no;
        private string name;

        private int age;
        //Creating static property
        public static int Number
        {
            set
            {
                //value basically set value in no which we get during calling above property
                no = value;
            }
            get
            {
                return no;
            }
        }

        public static string Name
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }


        //Here we are trying to access non static variable inside static property which will give an error
        //public static int MyProperty 
        //{
        //    set
        //    {
        //        age = value;
        //    }
        //    get
        //    {
        //        return age;
        //    }
        //}
    }



    public class Program
    {
        static void Main(string[] args)
        {
            //Accessing through class because it is static property
            A.Number = 1;

            A.Name = "Rudra Oberoi";
            Console.WriteLine(A.Number);
        }
    }

}