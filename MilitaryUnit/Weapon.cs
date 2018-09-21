using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapon
    {
        public virtual void FireWeapon()
        {
            Console.WriteLine($"Weapon Fired");
        }

        public void WeaponJammed(string noiseOfWeaponJammed)
        {
            Console.WriteLine($"Weapon made a loud {noiseOfWeaponJammed}.. Weapon must be jammed!");
        }

        public void WeaponReload()
        {
            Console.WriteLine($"RELOADING!!");
        }
    }
}
