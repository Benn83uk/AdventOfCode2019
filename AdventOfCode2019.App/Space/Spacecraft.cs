using System.IO;
using System.Linq;

namespace AdventOfCode2019.App.Space
{
    public class Spacecraft
    {
        private readonly Module[] _modules;

        public Spacecraft(params Module[] modules)
        {
            _modules = modules;
        }

        public Spacecraft(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            _modules = lines.Select(line => new Module(int.Parse(line))).ToArray();
        }

        public int FuelRequired()
        {
            return _modules.Sum(m => m.FuelRequired());
        }

        public int FuelRequiredIncludingFuel()
        {
            return _modules.Sum(m => m.TotalFuelRequired());
        }
    }
}