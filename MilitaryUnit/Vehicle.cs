using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicle
    {
        public void StartingEngine(string noiseOfEngineStart)
        {
            Console.WriteLine($"Starting engine: {noiseOfEngineStart}");
        }

        public void StopEngine(string noiseOfEngineStop)
        {
            Console.WriteLine($"Shutting engine down: {noiseOfEngineStop}");
        }
    }
}
