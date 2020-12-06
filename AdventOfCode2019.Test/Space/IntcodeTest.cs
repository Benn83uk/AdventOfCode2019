using AdventOfCode2019.App.Space;
using NUnit.Framework;

namespace AdventOfCode2019.Test.Space
{
    [TestFixture]
    public class IntcodeTest
    {
        [Test]
        public void ImmediateTerminationReturns99()
        {
            var intcode = new Intcode(99);
            Assert.That(intcode.Run(), Is.EqualTo(99));
        }
        
        [Test]
        public void AddAndStoreAtZero()
        {
            var intcode = new Intcode(1, 5, 6, 0, 99, 8, 9);
            Assert.That(intcode.Run(), Is.EqualTo(17));
        }
        
        [Test]
        public void MultiplyndStoreAtZero()
        {
            var intcode = new Intcode(2, 5, 6, 0, 99, 8, 9);
            Assert.That(intcode.Run(), Is.EqualTo(72));
        }
    }
}