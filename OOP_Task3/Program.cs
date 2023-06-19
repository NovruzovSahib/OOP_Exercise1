using OOP_Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        Planet planet = new SolarSystem();
        planet.Name = "Earth";
        planet.Age = 4543000000;
        planet.RotationAroundTime = 24;
        planet.RotationAroundSunTime = 7400;
        planet.DistanceFromSun = 1520000000;
        planet.Radius = 6371000;
        planet.IsWaterExist = true;
        planet.IsOxygenExist = true;
        planet.PlanetInfo();
        planet.NumberOfSatellite(7702);
        Console.WriteLine();

        planet.Name = "Venera";
        planet.Age = 45000000;
        planet.RotationAroundTime = 243;
        planet.RotationAroundSunTime = 225;
        planet.DistanceFromSun = 10836000000;
        planet.Radius = 6051;
        planet.IsWaterExist = false;
        planet.IsOxygenExist = false;
        planet.PlanetInfo();
        planet.NumberOfSatellite(16);

        Console.ReadLine();
    }
}