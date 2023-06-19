using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Satellite
    {
        string color;
        long age;
        int radius;

        public string Color { get; set; }
        public long Age { get; set; }
        public int Radius { get; set; }

        public Satellite()
        {
            this.Color = color;
            this.Age = age;
            this.Radius = radius;
        }
        public virtual void SatelliteInfo()
        {
            Console.WriteLine($"Satellite color - {Color}\nAge - {Age}\nRadius - {Radius}");
        }
    }
}
