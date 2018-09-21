using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Personnel
    {
        public void Armor(string typeOfArmorWorn, string typeOfSoldier)
        {
            Console.WriteLine($"Your {typeOfSoldier} is wearing {typeOfArmorWorn}");
        }
        
        public void Gender(string input)
        {
            if (input == "m")
            {
                Console.WriteLine("Male Soldier");
            }
            else if(input == "f")
            {
                Console.WriteLine("Female Soldier");
            }
            else
            {
                Console.WriteLine("There are but 2 genders.. m, or f..");
            }
        }
    }
}
