using System;

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
            return (int)(Math.Floor((double)_mass / 3.0) - 2);
        }
    }
}