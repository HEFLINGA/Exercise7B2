using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Medic : Personnel
    {
        public Medic(string name)
        {
            this.name = name;
        }

        public void Surgery()
        {
            Console.WriteLine("Medics perform surgery..");
        }

        public void PatchUp(string woundType)
        {
            Console.WriteLine($"Medics do there best to patch up {woundType}");
        }
    }
}
