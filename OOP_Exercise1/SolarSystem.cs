using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1
{
    internal abstract class SolarSystem
    {
        string planetName;
        string planetColor;
        double distanceFromSun;
        bool isLifeExist;

        public string PlanetName { get; set; }
        public string PlanetColor { get; set; }
        public double DistanceFromSun { get; set; }
        public bool IsLifeExist { get; set; }


        public SolarSystem()
        {
            this.PlanetName = planetName;
            this.PlanetColor = planetColor;
            this.DistanceFromSun = distanceFromSun;
            this.IsLifeExist = true;
        }
        ~SolarSystem()
        {
            Console.WriteLine("Destructor was called");
        }
        public abstract void GetInfo();
    }
}
