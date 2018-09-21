using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Infantry : Personnel
    {
        public Infantry(string name)
        {
            this.name = name;
        }

        public void Assault()
        {
            Console.WriteLine("The infantry moved on the assault!");
        }

        public void Defence()
        {
            Console.WriteLine("The infantry moved on the defence and began planning..");
        }
    }
}
