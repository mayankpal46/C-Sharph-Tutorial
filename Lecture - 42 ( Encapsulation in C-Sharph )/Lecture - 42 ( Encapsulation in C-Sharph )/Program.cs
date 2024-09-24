using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___42___Encapsulation_in_C_Sharph__
{
    public class A
    {
        private int x; 
        public string s;
        public int y;
        private string st = "roy";

        public void setno(int no)
        {
            this.x = no;
            Console.WriteLine("Public Method");
        }

        public void getno()
        {
            Console.WriteLine("my no is : " + x);
        }

        public void sets(string s)
        {
            this.s = s;
            Console.WriteLine("Public Method");
        }

        public void gets()
        {
            Console.WriteLine("my string is : " + s);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();

            //Because y is public 
            obj.y = 100;

            obj.setno(100);

            obj.getno();

            obj.sets("Rudhra");
            obj.gets();
            obj

        }
    }
}
