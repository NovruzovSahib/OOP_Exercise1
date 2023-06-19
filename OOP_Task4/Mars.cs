using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Task4
{
    internal class Mars:Planet
    {
        public long DistanceFromSun { get; set; }
        public Mars(string color,string description,long age,long distanceFromSun) :base(color, description, age)
        {
            this.DistanceFromSun = distanceFromSun; 
        }
        public override void PlanetInfo()
        {
            base.PlanetInfo();
            Console.WriteLine($"Distance from Sun - {DistanceFromSun}");
        }
    }
}
