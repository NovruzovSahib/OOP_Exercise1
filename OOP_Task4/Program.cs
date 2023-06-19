using OOP_Task4;

internal class Program
{
    private static void Main(string[] args)
    {
        Earth earth = new Earth("Blue", "Our home planet Earth is a rocky, terrestrial planet. ", 4543000000,true);
        earth.PlanetInfo();
        Console.WriteLine();

        Mars mars = new Mars("Golden", "Mars is the fourth planet from the Sun – a dusty, cold, desert world with a very thin atmosphere. ", 4603000000,250420000);
        mars.PlanetInfo();

        Console.ReadLine();
    }
}