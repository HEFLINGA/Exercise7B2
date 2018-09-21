using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        public static void DefenceStoryLine()
        {
            Console.WriteLine(" Oh man! the Lead vehicle hit a huge explosive, sending " +
                "the vehicle flying.. You hear enemies firing at you from all directions, and you have to crawl your way to the north side of the jeep.. the only side not currently being destroyed " +
                "by incoming fire! You try for the radio, but they seem to have you locked down with suppressive fire. If only you could get to that radio, you might be able to call for some jets.");
        }
        public static void AssaultStoryLine()
        {
            Console.WriteLine("You ride up on the enemy convoy as it passes through a bottle neck in a near-by valley! You got'em for sure! You immediatly call in your airsupport to make sure there " +
                "is no way these guys have anyway to retaliate or react. Easy day, easy life.");
        }
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

            bool game = true;
            int input = 0;

            // "Game" loop. Didnt make seperate menu classes since the focus was how the inheretence worked. (A little cluttered, but it runs)
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a mission: ");
                Console.WriteLine("1. Assault");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Exit");

                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        raid.TaskingType();
                        AR15.ARType("AR-15");
                        AR15.ExtendedMag();
                        AR15.MuzzleBreak();
                        Console.WriteLine("Press enter to continue to the fight:");
                        Console.ReadLine();
                        Console.Clear();
                        AssaultStoryLine();
                        AR15.FireWeapon();
                        F16.TakeOff(pilot1.name);
                        AR15.WeaponReload();
                        AR15.WeaponJammed("SNAP");
                        Console.WriteLine("Press enter to continue:");
                        Console.ReadLine();
                        Console.Clear();
                        F16.CrashLanding(pilot1.name);
                        Console.WriteLine("As the assault continues you here over the radio a pilot had to eject from there plane.. you just hope it wasnt someone you knew..");
                        AR15.FireWeapon();
                        medic1.PatchUp("Minor bullet wounds");
                        Console.WriteLine("Everything finally ended many hours later. Made it out alive.. Who knows how that went so terribly wrong.");
                        wrangler.StartingEngine("SQQUUEEEELLLLL");
                        wrangler.Drive();
                        Console.WriteLine("You arrive back at base pretty beat up.. but youll survive.");
                        wrangler.StopEngine("VRUmmmm...");
                        medic1.Surgery();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        RPG.RocketLauncherType("RPG");
                        RPG.ExplosionSize();
                        Console.WriteLine("Press enter to continue to the fight:");
                        Console.ReadLine();
                        Console.Clear();                   
                        wrangler.StartingEngine("Rumm rum rumm");
                        wrangler.Drive();
                        wrangler.TireBlow(infantry1.name);
                        DefenceStoryLine();
                        RPG.FireWeapon();
                        littleBird.TakeOff(pilot1.name);
                        RPG.WeaponReload();
                        RPG.WeaponJammed("BOOM");
                        Console.WriteLine("Press enter to continue:");
                        Console.ReadLine();
                        Console.Clear();
                        littleBird.CrashLanding(pilot1.name);
                        Console.WriteLine("As the assault continues you here over the radio a pilot and his helicopter went down.. you just hope it wasnt someone you knew..");
                        RPG.FireWeapon();
                        Console.WriteLine("Everything finally ended many hours later. Made it out alive.. Who knows how that went so terribly wrong.");
                        wrangler.StartingEngine("Vroom, Vroommmm!");
                        wrangler.Drive();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        game = false;
                        break;
                    default:
                        Console.WriteLine("Choose a different input: ");
                        break;
                }
            } while (game == true);            
        }
    }
}
