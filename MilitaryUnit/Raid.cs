using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Raid : Assault
    {
        public override void TaskingType()
        {
            Console.WriteLine("You are tasked with Raiding an enemy supply line.");
        }
    }
}
