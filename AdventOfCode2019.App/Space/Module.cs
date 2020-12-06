using System;
using System.Linq.Expressions;

namespace AdventOfCode2019.App.Space
{
    public class Module
    {
        private readonly int _mass;

        public Module(int mass)
        {
            _mass = mass;
        }

        public int FuelRequired()
        {
            return FuelForMass(_mass);
        }

        private int FuelForMass(int mass)
        {
            return (int) (Math.Floor((double) mass / 3.0) - 2);
        }

        public int TotalFuelRequired()
        {
            return FuelForMassPlusFuel(_mass);
        }

        private int FuelForMassPlusFuel(int mass)
        {
            var fuelForMass = FuelForMass(mass);
            if (fuelForMass <= 0) return 0;
            return fuelForMass + FuelForMassPlusFuel(fuelForMass);
        }
    }
}