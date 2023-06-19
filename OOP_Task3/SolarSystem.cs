using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task3
{
    internal class SolarSystem : Planet
    {
        public override int NumberOfSatellite(int numberofsatellite)
        {
            Console.WriteLine($"Number of satellite is {numberofsatellite}");
            return numberofsatellite;
        }

    }
}
