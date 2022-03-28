using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    internal class Planet
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public int Diameter { get; set; }
        public int Density { get; set; }
        public double Gravity { get; set; }
        public double RotationPeriod { get; set; }
        public double LengthOfDay { get; set; }
        public double DistanceFromSun { get; set; }
        public double OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
        public int MeanTemperature { get; set; }
        public byte NumberOfMoons { get; set; }
        public bool IsRingSystem { get; set; }

        public Planet(string name, double mass, int diameter, int density, double gravity, double rotationPeriod, double lengthOfDay, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, int meanTemperature, byte numberOfMoons, bool isRingSystem)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoons;
            IsRingSystem = isRingSystem;
        }

        public override string ToString()
        {
            return $"{Name} properties: \n\n" +
                $"Mass (1024kg): {Mass}\n" +
                $"Diameter (km): {Diameter}\n" +
                $"Gravity (m/s^2): {Gravity}\n" +
                $"Rotation period (hours): {RotationPeriod}\n" +
                $"Length of Day (hours): {LengthOfDay}\n" +
                $"Distance from sun (106km): {DistanceFromSun}\n" +
                $"Orbital period (days): {OrbitalPeriod}\n" +
                $"Orbital velocity (km/s): {OrbitalVelocity}\n" +
                $"Mean temperature (celcius): {MeanTemperature}\n" +
                $"Number of moons: {NumberOfMoons}\n" +
                $"Ring system? {(IsRingSystem == true ? "Yes" : "No")}\n\n";
        }
    }
}
