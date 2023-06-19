using OOP_Exercise1;
using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {
        SolarSystem solarSystem = new BaseSolarSystem();
        solarSystem.PlanetName = "Earth";
        solarSystem.PlanetColor = "Cyan";
        solarSystem.DistanceFromSun = 152;
        solarSystem.IsLifeExist = true;
        solarSystem.GetInfo();
        Console.WriteLine();

        solarSystem.PlanetName = "Jupiter";
        solarSystem.PlanetColor = "Orange";
        solarSystem.DistanceFromSun = 741.56;
        solarSystem.IsLifeExist = false;
        solarSystem.GetInfo();
        Console.WriteLine();

        solarSystem.PlanetName = "Pluto";
        solarSystem.PlanetColor = "Brownish-red";
        solarSystem.DistanceFromSun = 3700;
        solarSystem.IsLifeExist = false;
        solarSystem.GetInfo();
        Console.ReadLine();
    }
}