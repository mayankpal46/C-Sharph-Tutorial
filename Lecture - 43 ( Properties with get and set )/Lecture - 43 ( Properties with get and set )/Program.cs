using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___43___Properties_with_get_and_set__
{
    class A
    {
        private int _id;
        private string _name="No name required";
        private int _no;

        //Creating properties
        public int StdId
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        //Readonly property
        public string ronly
        {
            get
            {
                return this._name;
            }
        }

        public string autoproperty { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            
            //Here setter will work
            obj.StdId = 1;

            //Here getter will work
            Console.WriteLine(obj.StdId);
            Console.WriteLine(obj.ronly);

            //for autoimplemented 
            obj.autoproperty = "Auto Implemented Property";
            Console.WriteLine(obj.autoproperty);
        }
    }
}
