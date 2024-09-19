using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___39___Types_of_Inheritance_in_C_Sharph__
{ 
    // Multilevel Inheritance Starts Here
    public class ClassA:ClassB
    {
        public int Id;
    }

    public class ClassB : ClassC
    {
        public string Name;
    }

    public class ClassC
    {
        public string Address;

    }

    // Ends Here



    internal class Program
    {
        static void Main(string[] args)
        {
            //Four types of Inheritance :- Single , Herirchcal , Multiple , Multilevel

            //Creating object of child class which can access variable of class B & class C
            ClassA obj = new ClassA();
            obj.Name = "Rudra";
            obj.Address = "Obreoi Mansion";
            obj.Id = 100;

            Mynewclass mobj = new Mynewclass();
            mobj.Newvar = 100;
            mobj.Name = "Omkara";

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);
            Console.WriteLine(obj.Id);

            Console.ReadLine();


        }
    }
}
