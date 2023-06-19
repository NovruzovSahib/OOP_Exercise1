using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Moon:Satellite
    {
        bool isWaterExist;
        public bool IsWaterExist { get; set; }
        public Moon()
        {
            this.IsWaterExist = isWaterExist;
        }
        public override void SatelliteInfo()
        {
            base.SatelliteInfo();
            Console.WriteLine($"Is Water Exist? - {IsWaterExist}");
        }
    }
}
