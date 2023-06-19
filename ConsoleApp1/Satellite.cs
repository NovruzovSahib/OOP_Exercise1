using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    internal class Satellite
    {
        string name;
        string description;
        int age;


        public string Name { get; set; }
        public string Description { get; set; }
        public long Age { get; set; }

        public Satellite()
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
        }
        public void GetSatellite()
        {
            Console.WriteLine($"Satellite name - {Name}\nDescription - {Description}\nAge - {Age}\n");
        }
    }
}
