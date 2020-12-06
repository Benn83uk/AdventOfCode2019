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

        [Test]
        public void DayTwoExample()
        {
            var intcode = new Intcode(1,9,10,3,2,3,11,0,99,30,40,50);
            Assert.That(intcode.Run(), Is.EqualTo(3500));
        }
        
        [Test]
        public void DayTwoExample5()
        {
            var intcode = new Intcode(1,1,1,4,99,5,6,0,99);
            Assert.That(intcode.Run(), Is.EqualTo(30));
        }
        
        [Test]
        public void DayTwoAnswer()
        {
            var intcode = new Intcode(1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,13,19,1,10,19,23,2,9,23,27,1,6,27,31,1,10,31,35,1,35,10,39,1,9,39,43,1,6,43,47,1,10,47,51,1,6,51,55,2,13,55,59,1,6,59,63,1,10,63,67,2,67,9,71,1,71,5,75,1,13,75,79,2,79,13,83,1,83,9,87,2,10,87,91,2,91,6,95,2,13,95,99,1,10,99,103,2,9,103,107,1,107,5,111,2,9,111,115,1,5,115,119,1,9,119,123,2,123,6,127,1,5,127,131,1,10,131,135,1,135,6,139,1,139,5,143,1,143,9,147,1,5,147,151,1,151,13,155,1,5,155,159,1,2,159,163,1,163,6,0,99,2,0,14,0);
            Assert.That(intcode.Run(), Is.EqualTo(11590668));
        }

        [Test]
        public void ReplaceFirstTwoParameters()
        {
            var intcode = new Intcode(1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,13,19,1,10,19,23,2,9,23,27,1,6,27,31,1,10,31,35,1,35,10,39,1,9,39,43,1,6,43,47,1,10,47,51,1,6,51,55,2,13,55,59,1,6,59,63,1,10,63,67,2,67,9,71,1,71,5,75,1,13,75,79,2,79,13,83,1,83,9,87,2,10,87,91,2,91,6,95,2,13,95,99,1,10,99,103,2,9,103,107,1,107,5,111,2,9,111,115,1,5,115,119,1,9,119,123,2,123,6,127,1,5,127,131,1,10,131,135,1,135,6,139,1,139,5,143,1,143,9,147,1,5,147,151,1,151,13,155,1,5,155,159,1,2,159,163,1,163,6,0,99,2,0,14,0);
            Assert.That(intcode.Run(12, 2), Is.EqualTo(11590668));
        }
    }
}