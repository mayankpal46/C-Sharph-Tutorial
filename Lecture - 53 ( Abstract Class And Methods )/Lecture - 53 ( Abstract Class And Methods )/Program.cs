using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___53___Abstract_Class_And_Methods__
{
    //Abstract class
    abstract class A
    {
        //public void M1()
        //{
        //    Console.WriteLine("Method in Abstract class");
        //}

        public int no;
        public string name;
        public string address;
        public int mprop;

        //Abstract Method
        public abstract void abmet();

        public int newprop 
        {
            set
            {
                this.mprop = value;
            }
            get
            {
                return this.mprop;
            }
        }

    }

    class B : A
    {
        public int Bp1;
        public string Bp2;

        public override void abmet()
        {
            Bp2 = "My name is : " + this.name;
            Console.WriteLine(Bp2);
        }
    }

    class C : A
    {
        public int Cp1;
        public string Cp2;

        public override void abmet()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Class B object
            B p = new B();
            p.no = 1;
            p.Bp1 = 121;
            Console.WriteLine(p.no);
            Console.WriteLine(p.Bp1);
            p.name = "Rudra";
            p.abmet();
            p.newprop = 1001;
            Console.WriteLine("Property value is : " + p.mprop);
        }
    }
}
