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
    }
}