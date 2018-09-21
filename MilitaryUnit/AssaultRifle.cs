using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class AssaultRifle : Weapon
    {
        public void ARType(string assaultRifleType)
        {
            Console.WriteLine($"Assault rifle type: {assaultRifleType}");
        }

        public void ExtendedMag()
        {
            Console.WriteLine("You have an extended mag on this assault rifle!");
        }

        public void MuzzleBreak()
        {
            Console.WriteLine("This weapon has a muzzle break!");
        }
    }
}
