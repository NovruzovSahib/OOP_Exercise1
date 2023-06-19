using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task3
{
    internal abstract class Planet
    {
        string name;
        long age;
        int rotationAroundTime;
        int rotationAroundSunTime;
        long distanceFromSun;
        int radius;
        bool isWaterExist;
        bool isOxygenExist;

        public string Name { get; set; }
        public long Age { get; set; }
        public int RotationAroundTime { get; set; }
        public int RotationAroundSunTime { get; set; }
        public long DistanceFromSun { get; set; }
        public int Radius { get; set; }
        public bool IsWaterExist { get; set; }
        public bool IsOxygenExist { get; set; }

        public Planet()
        {
            this.Name = name;
            this.Age = age;
            this.RotationAroundTime = rotationAroundTime;
            this.RotationAroundSunTime = rotationAroundSunTime;
            this.DistanceFromSun = distanceFromSun;
            this.Radius = radius;
            this.IsWaterExist = isWaterExist;
            this.IsOxygenExist = isOxygenExist;
        }
        public Planet(string _name, long _age, int _rotationAroundTime, int _rotationAroundSunTime, long _distanceFromSun, int _radius, bool _isWaterExist, bool _isOxygenExist)
        {
            this.Name = _name;
            this.Age = _age;
            this.RotationAroundTime = _rotationAroundTime;
            this.RotationAroundSunTime = _rotationAroundSunTime;
            this.DistanceFromSun = _distanceFromSun;
            this.Radius = _radius;
            this.IsWaterExist = _isWaterExist;
            this.IsOxygenExist = _isOxygenExist;
        }
        ~Planet()
        {
            Console.WriteLine($"Planet məhv edildi – {Name}");
        }
        public abstract int NumberOfSatellite(int numberofsatellite);
        public void PlanetInfo()
        {
            Console.WriteLine($"Planet Name - {Name}\nAge - {Age}\nRotation Around Time - {RotationAroundTime}\nRotation Around Sun Time - {RotationAroundSunTime}\nDistance from Sun - {DistanceFromSun}\nRadius - {Radius}\nIs Water Exist - {IsWaterExist}\nIs Oxygen Exist - {IsOxygenExist}");
        }
    }
}
