using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Abstraction_in_C___
{
    class A
    {
        public int num;
        public string name;
        public string address;
        double phoneno;
        double bankno;

        public A(int no , string naam , string add)
        {
            this.num = no;
            this.name = naam;
            this.address = add;
        }

        // Created private because to hide this method , but calling it through public method
        private void m1()
        {
            // We are hiding implementation
            if(address!=null)
            {
                bankno = 100000;
                Console.WriteLine("Your bank account no is : " + bankno);
            }
            else
            {
                bankno = 0;
            }
        }

        public void M2()
        {
           
            this.m1();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A(10,"Rudra","Oberoi Mansion");
            obj.M2();
            Console.ReadLine();
        }
    }
}
