using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Jeep : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("The jeep drives off, towards its next task");
        }

        public void TireBlow(string driver)
        {
            Console.WriteLine($"Holy Sh** {driver}! We lost a tire!");
        }
    }
}
