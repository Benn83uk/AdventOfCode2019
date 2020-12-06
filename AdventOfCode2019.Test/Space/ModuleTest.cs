using AdventOfCode2019.App.Space;
using NUnit.Framework;

namespace AdventOfCode2019.Test.Space
{
    [TestFixture]
    public class ModuleTest
    {
        [Test]
        public void CalculateFuel()
        {
            var module = new Module(12);
            Assert.That(module.FuelRequired(), Is.EqualTo(2));
        }

        [Test]
        public void CalculateFuelIncludeFuelMassOfZero()
        {
            var module = new Module(14);
            Assert.That(module.TotalFuelRequired(), Is.EqualTo(2));
        }
        
        [Test]
        public void CalculateFuelIncludeFuelMassOfFuel()
        {
            var module = new Module(1969);
            Assert.That(module.TotalFuelRequired(), Is.EqualTo(966));
        }
        
        [Test]
        public void CalculateFuelIncludeFuelMassOfFuel2()
        {
            var module = new Module(100756);
            Assert.That(module.TotalFuelRequired(), Is.EqualTo(50346));
        }
    }
}