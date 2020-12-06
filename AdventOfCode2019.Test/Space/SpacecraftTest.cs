using AdventOfCode2019.App.Space;
using NUnit.Framework;

namespace AdventOfCode2019.Test.Space
{
    [TestFixture]
    public class SpacecraftTest
    {
        [Test]
        public void CalculateFuelRequiredSingleModule()
        {
            var craft = new Spacecraft(
                new Module(12)
            );
            Assert.That(craft.FuelRequired(), Is.EqualTo(2));
        }
        
        [Test]
        public void CalculateFuelRequiredMultipleModules()
        {
            var craft = new Spacecraft(
                new Module(12),
                new Module(14),
                    new Module(1969),
                new Module(100756)
            );
            Assert.That(craft.FuelRequired(), Is.EqualTo(34241));
        }
        
        [Test]
        public void CalculateFuelRequiredFromFile()
        {
            var craft = new Spacecraft("TestFiles/DayOneExample.txt");
            Assert.That(craft.FuelRequired(), Is.EqualTo(34241));
        }
    }
}