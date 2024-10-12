using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___63___List_Generic_Part_1___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(1);
            mylist.Add(291);
            mylist.Add(103);

            Console.WriteLine("After adding 3 elements : " + mylist.Capacity);
            Console.WriteLine('\t');
            //After adding two more items
            mylist.Add(913);
            mylist.Add(77);

            Console.WriteLine("After adding two more elements : " + mylist.Capacity);
            Console.WriteLine('\t');

            Console.WriteLine("Accessing elements");
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\t');

            Employee obs = new Employee()
            {
                Age = 100,
                Name = "Omkara"

            };

            Employee ob = new Employee()
            {
                Age = 101,
                Name = "Rudra"

            };

            //Creating list of Employee class
            List<Employee> employees = new List<Employee>();
            employees.Add(obs);
            employees.Add(ob);

            foreach(var item in employees)
            {
                Console.WriteLine("Age is : " + item.Age + "   And   " + "Name is : " + item.Name);
            }
            
        }
    }
}
