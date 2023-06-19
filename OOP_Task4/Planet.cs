using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task4
{
    internal class Planet
    {
        public string Color { get; set; }
        public string Description { get; set; }
        public long Age { get; set; }

        public Planet(string color, string description, long age)
        {
            this.Color = color;
            this.Description = description;
            this.Age = age;
        }

        public virtual void PlanetInfo()
        {
            Console.WriteLine($"Planet color {Color}\nDescription - {Description}\nAge - {Age}");
        }
    }
}
