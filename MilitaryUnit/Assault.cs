using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Assault : Tasking
    {
        public override void TaskingType()
        {
            Console.WriteLine("Your task is an Assault mission!!");
        }
    }
}
