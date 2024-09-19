using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___38___Inheritance_in_C_Sharph__
{
    
    class PermanentEmployee : Employee
    {
        public int Psalary;
        public int Phours;
    }

    //To use variables which are present in parent class , so for that we : 
    class VistingEmployee : Employee
    {

        public int Vsalary;
        public int Vhours;

        public void mymethod()
        {
            Console.WriteLine("Visting Employee Method");
        }
    }

    //Parent Class or Base Class
    class Employee
    {
        public int Empid;
        public string Empname;
        public int Empage;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            VistingEmployee vobj = new VistingEmployee();
            vobj.Vsalary = 100000000;

            //Calling method which is present in child class
            vobj.mymethod();

            PermanentEmployee pobj = new PermanentEmployee();
            pobj.Empid = 20;

            Console.WriteLine("Visting Employee class : " + vobj.Vsalary);
            Console.WriteLine("Permanent Employee class : " + pobj.Empid);


            Console.ReadLine();

        }
    }
}
