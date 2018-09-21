using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instantiation
            RocketLauncher RPG = new RocketLauncher();
            Raid raid = new Raid();
            Pilot pilot1 = new Pilot("Samual");
            Jeep wrangler = new Jeep();
            Helicopter littleBird = new Helicopter();
            Convoy convoy = new Convoy();
            AssaultRifle AR15 = new AssaultRifle();
            Infantry infantry1 = new Infantry("John");
            Medic medic1 = new Medic("Sally");
            Jet F16 = new Jet();
            #endregion

            // Story to give this program some life:
            Console.WriteLine("Welcome Soldier! Lets get you up to speed.");
            Console.WriteLine("Press Enter to continue: ");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine(" You have just arrived at FOB Del Din. Things are a little crazy up here, but for the most part we just have a two simple taskings: Defend a" +
                " Convoy of supplies that passes through here, heading to our Soldiers up north, and Stop the enemy from Shuttling there own supplies along the borders via raids on there supply lines.");
            Console.WriteLine($"\n You have a couple good battle buddies around here who will help you out. You got the Medic, {medic1.name}. You got the Grunt (infantry guy, like yourself) " +
                $"{infantry1.name}, and you got our world famous pilot, {pilot1.name}");
            Console.WriteLine("\n Anyways, Not to rush you to much, but we need to to pick a mission and a weapon. We move fast around here.");
            Console.WriteLine("Press enter to continue:");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
