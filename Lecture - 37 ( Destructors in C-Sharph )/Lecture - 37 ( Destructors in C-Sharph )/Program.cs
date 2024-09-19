using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___37___Destructors_in_C_Sharph__
{
    class Newclass
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Creating Constructor :- It's name is also same as class name and we are creating it to intialize above variables 
        public Newclass(string name , string desc) 
        { 
            //this is reffering to class variables
            this.Name = name;
            this.Description = desc;
        }

        //These are methods
        //We are getting values through getters
        public string getName()
        {
            return this.Name;
        }

        //Getting Method
        public string getDescription()
        {
            return this.Description;
        }

        //Creating destructor
        ~Newclass()
        {
            Console.WriteLine("Destructor Started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Newclass obj = new Newclass("Rudhra","Developer");
            Newclass obj1 = new Newclass("Omkara", "Buisnessman");

            Console.WriteLine(obj.getDescription());
            Console.WriteLine(obj.getName());

            Console.WriteLine(obj1.getDescription());
            Console.WriteLine(obj1.getName());


        }
    }
}
