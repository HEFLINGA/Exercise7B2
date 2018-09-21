using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tasking
    {
        public void TaskingTime(int time)
        {
            Console.WriteLine($"This task will take you {time}");
        }


        public virtual void TaskingType()
        {
            Console.WriteLine("You have a task");
        }

    }
}