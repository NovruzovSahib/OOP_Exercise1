using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Terra:Satellite
    {
        short distanceFromSun;
        public short DistanceFromSun { get; set; }
        public Terra()
        {
            this.DistanceFromSun = distanceFromSun;
        }

        public override void SatelliteInfo()
        {
            base.SatelliteInfo();
            Console.WriteLine($"Distance from Sun - {DistanceFromSun}");
        }
    }
}
