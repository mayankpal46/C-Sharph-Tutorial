using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture___40___Access_Specifier___Part_1____;

namespace NewNamespace
{
    
    class namsp : A
    {
        static void Main(string[] args)
        { 
            A ob = new A();
            ob.M1();

            //Inherit parent class which is present in another namespace & then creating object of our child class
            namsp obs = new namsp();
            obs.M3();
        }
    }
}
