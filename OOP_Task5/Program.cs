using OOP_Task5;

internal class Program
{
    private static void Main(string[] args)
    {
        Moon moon = new Moon();
        moon.Color = "brown-gray";
        moon.Age = 4510000000;
        moon.Radius = 1737;
        moon.IsWaterExist = false;
        moon.SatelliteInfo();
        Console.WriteLine();

        Terra terra = new Terra();
        terra.Color = "reddish";
        terra.Age = 24;
        terra.Radius = 25;
        terra.DistanceFromSun = 705;
        terra.SatelliteInfo();
        Console.ReadLine();
    }
}