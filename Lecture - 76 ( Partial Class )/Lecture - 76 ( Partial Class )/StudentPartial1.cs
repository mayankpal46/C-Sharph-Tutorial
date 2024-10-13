using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___76___Partial_Class__
{
    public partial class myc
    {
        private string name;
        private int age;

        public int Ageprop
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }

        public string Nameprop
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
    }
}
