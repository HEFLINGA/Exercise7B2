using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Personnel
    {
        public string name;

        public void Armor(string typeOfArmorWorn, string typeOfSoldier)
        {
            Console.WriteLine($"You are: {typeOfSoldier}, wearing {typeOfArmorWorn}");
        }
    }
}
