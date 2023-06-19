using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task4
{
    internal class Earth:Planet
    {
        public bool IsLifeExist { get; set; }
        public Earth(string color,string description,long age,bool isLifeExist):base(color,description,age)
        {
            this.IsLifeExist = isLifeExist; 
        }
        public override void PlanetInfo()
        {
            base.PlanetInfo();
            Console.WriteLine($"IsLifeExist - {IsLifeExist}");
        }
    }
}
