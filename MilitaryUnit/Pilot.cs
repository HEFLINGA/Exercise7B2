using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Pilot : Personnel
    {
        public Pilot(string name)
        {
            this.name = name;
        }

        public void Fly(string planeOrHelicoptor)
        {
            Console.WriteLine($"Pilot Flies the {planeOrHelicoptor}");
        }

        public void Eject()
        {
            Console.WriteLine("Abort! Abort! Pilot had to eject from plane!");
        }
    }
}
