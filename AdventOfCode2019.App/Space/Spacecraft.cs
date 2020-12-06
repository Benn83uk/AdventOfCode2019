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

        public int FuelRequired()
        {
            return _modules.Sum(m => m.FuelRequired());
        }
    }
}