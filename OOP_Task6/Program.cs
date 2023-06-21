using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            MyClass myClass = new MyClass();
            myClass = null;
        }
        GC.Collect();

        Console.ReadLine();
    }

    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor");
        }
        ~MyClass()
        {
            Console.WriteLine("Destructor");
        }
    }
}