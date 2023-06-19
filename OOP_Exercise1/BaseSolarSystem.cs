using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1
{
    internal class BaseSolarSystem : SolarSystem
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Planet Name - {PlanetName}\nPlanet Color - {PlanetColor}\nPlanet Distance from Sun - {DistanceFromSun}\nIs there life? - {IsLifeExist}");
        }
    }
}
