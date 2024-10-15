using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___80___What_is_StringBuilder__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two ways to intialize stringbuilder
            
            //one way
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("name1");
            //Console.WriteLine(sb);

            //second way
            StringBuilder sb2 = new StringBuilder("Kuchbhi");

            sb2.Append("Abe nahi be");
            sb2.AppendLine("Accha");

            //Console.WriteLine(sb2);

            StringBuilder obs = new StringBuilder("Rudra");
            obs.Insert(2, "p");
            Console.WriteLine(obs);

            StringBuilder sb3 = new StringBuilder("My name is khan");
            sb3.Remove(4, 5);
            Console.WriteLine(sb3);

        }
    }
}
