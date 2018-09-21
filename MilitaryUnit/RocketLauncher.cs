using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class RocketLauncher : Weapon
    {
        public void RocketLauncherType(string RLType)
        {
            Console.WriteLine($"Rocket Launcher Type: {RLType}");
        }

        public void ExplosionSize()
        {
            Console.WriteLine("Explosion Radius: 100m");
        }

        public override void FireWeapon()
        {
            Console.WriteLine("Rocket Launcher fired");
        }
    }
}
