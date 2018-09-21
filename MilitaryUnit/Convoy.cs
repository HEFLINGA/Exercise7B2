using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Convoy : Defend
    {
        public override void TaskingType()
        {
            Console.WriteLine("You are tasked with defending a supply line for our troops on the line.");
        }
    }
}
