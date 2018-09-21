using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Helicopter : Vehicle
    {
        public void TakeOff(string pilotName)
        {
            Console.WriteLine($"The Helicopter takes off from the landing pad, into the sky!! Good luck up there {pilotName}");
        }

        public void CrashLanding(string pilotName)
        {
            Console.WriteLine($"Down came the Helicopter.. There's no way {pilotName} is gettin' outa this one alive..");
        }

        public void Landing(string pilotName)
        {
            Console.WriteLine($"Here comes the Helicopter! Good'ol {pilotName} never lets us down.");
        }
    }
}
