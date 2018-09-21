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

        public void PersonnelType(string typeOfSoldier)
        {
            Console.WriteLine($"This Personnel is a {typeOfSoldier}");
        }
    }
}
