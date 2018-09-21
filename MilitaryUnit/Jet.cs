using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Jet : Vehicle
    {
        public void TakeOff(string pilotName)
        {
            Console.WriteLine($"The jet takes off on the runway, into the sky!! Good luck up there {pilotName}");
        }

        public void CrashLanding(string pilotName)
        {
            Console.WriteLine($"Down came the multimillion dollar jet.. Hopefully {pilotName} got out in time..");
        }

        public void Landing(string pilotName)
        {
            Console.WriteLine($"Here comes the jet! Good'ol {pilotName} never lets us down.");
        }
    }
}
