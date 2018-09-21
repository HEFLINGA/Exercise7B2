using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapon
    {
        public void FireWeapon(string noiseOfWeaponFired)
        {
            Console.WriteLine($"Weapon went {noiseOfWeaponFired}");
        }

        public void WeaponJammed(string noiseOfWeaponJammed)
        {
            Console.WriteLine($"Weapon made a loud {noiseOfWeaponJammed}.. Weapon must be jammed!");
        }
    }
}
