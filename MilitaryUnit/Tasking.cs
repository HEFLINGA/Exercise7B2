using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tasking
    {
        public void TaskingType(string mission)
        {
            Console.WriteLine($"Your task is {mission}");
        }

        public void TaskingTime(int time)
        {
            Console.WriteLine($"This task will take you {time}");
        }
    }
}