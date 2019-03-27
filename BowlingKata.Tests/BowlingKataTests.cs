using System;
using NUnit.Framework;
using BowlingKata;

namespace BowlingKata.Tests

{
    public class BowlingKataTests
    {
        private Bowling _bowling;
        [SetUp]
        public void Setup()
        {
          _bowling = new Bowling();
        }

        [Test]
        public void TestCanScoreZeroGame()
        {
            for (var i = 0; i < 20; i++)
            {
                _bowling.Roll(0);
            }
            
            Assert.AreEqual(0, _bowling.Score());
        }
        
        [Test]
        public void TestCanScoreOnes()
        {
            for (var i = 0; i < 20; i++)
            {
                _bowling.Roll(1);
            }
            
            Assert.AreEqual(20, _bowling.Score());

        }
        [Test]
        public void TestCanScoreASpare()
        {
            _bowling.Roll(5);
            _bowling.Roll(5);
            _bowling.Roll(2);

            
            for (var i = 0; i < 17; i++)
            {
                _bowling.Roll(0);
            }
            
            Assert.AreEqual(14, _bowling.Score());

        }
        
        [Test]
        public void TestCanScoreASpareExample2()
        {
            _bowling.Roll(2);
            _bowling.Roll(8);
            _bowling.Roll(4);

            
            for (var i = 0; i < 17; i++)
            {
                _bowling.Roll(0);
            }
            
            Assert.AreEqual(18, _bowling.Score());

        }
        
        [Test]
        public void TestCanScoreASpareExample3()
        {
            _bowling.Roll(3);
            _bowling.Roll(7);
            _bowling.Roll(9);

            
            for (var i = 0; i < 17; i++)
            {
                _bowling.Roll(0);
            }
            
            Assert.AreEqual(28, _bowling.Score());

        }
    }
}