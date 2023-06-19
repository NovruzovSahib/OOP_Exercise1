using OOP_Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        Satellite satellite1 = new Satellite();
        satellite1.Name = "Moon";
        satellite1.Description = "The Moon is Earth's only natural satellite. Its diameter is about one-quarter of Earth's, making it the fifth largest satellite in the Solar System and the largest and most massive relative to its parent planet. It is larger than all known dwarf planets in the Solar System.";
        satellite1.Age = 4510000000;
        satellite1.GetSatellite();

        Satellite satellite2 = new Satellite();
        satellite2.Name = "Europa";
        satellite2.Description = "Europa, or Jupiter II, is the smallest of the four Galilean moons orbiting Jupiter, and the sixth-closest to the planet of all the 95 known moons of Jupiter. It is also the sixth-largest moon in the Solar System. ";
        satellite2.Age = 4500000000;
        satellite2.GetSatellite();

        Satellite satellite3 = new Satellite();
        satellite3.Name = "Ganymede";
        satellite3.Description = "Ganymede, or Jupiter III, is the largest and most massive natural satellite of Jupiter as well as in the Solar System, being a planetary-mass moon. It is the largest Solar System object without an atmosphere, despite being the only moon of the Solar System with a magnetic field. ";
        satellite3.Age = 4500000000;
        satellite3.GetSatellite();

        Console.ReadLine();
    }
}