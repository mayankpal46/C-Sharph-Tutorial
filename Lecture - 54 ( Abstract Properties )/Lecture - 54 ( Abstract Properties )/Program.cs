using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___54___Abstract_Properties__
{
    abstract class A
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
    }

    class B : A
    {
        int ID;
        string Naam;

        //Setting and getting value for abstract properties
        public override int Id 
        {
            set
            {
                this.ID = value;
            }
            get
            {
                return this.ID;
            }
        }
        public override string Name 
        {
            set
            {
                this.Naam = value;
            }
            get
            {
                return this.Naam;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.Id = 100;
            obj.Name = "test";
            Console.WriteLine(obj.Id);
            Console.WriteLine(obj.Name);

            Console.ReadLine();
        }
    }
}
