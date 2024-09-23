using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___41___Access_Specifier___Part_2____
{
    public class A
    {
        public int Value;
        private int Id;
        internal int desc;
        private void M1()
        {
            Console.WriteLine("Private Method");
        }

        public void M3()
        {
            Console.WriteLine("Public Method");
        }
        
        protected void M4()
        {
            Console.WriteLine("Protected Method");
        }

        internal void M5()
        {
            A obs = new A();
            obs.M1();
            Console.WriteLine("Internal Method");
        }    
    }

    
    class Program : A
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.Value = 1;
            //Private variable not able to access outside that class
            //obj.Id=2;

            //Not able to access private method;
            //obj.M1();

            //Protected member is inaccessible outside the class
            //obj.M4();

            Program ob = new Program();
            ob.M4();

            ob.M5();
            
        }
    }
}
