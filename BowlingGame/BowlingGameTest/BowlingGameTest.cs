using NUnit.Framework;
using BowlingGame;

namespace BowlingGameTest
{
    [TestFixture]
    public class BowlingGameTest
    {
        private Game g;

        [SetUp]
        public void CreateGame()
        {
            g = new Game();    
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void RollStrike()
        {
            g.Roll(10);
        }

        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.That(0, Is.EqualTo(g.Score()));
        }
        
        [Test]
        public void TestOneSpare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17,0);
            Assert.That(16, Is.EqualTo(g.Score()));
        }
        
        [Test]
        public void TestOneStrike()
        { 
            RollStrike();
            g.Roll(3); 
            g.Roll(4); 
            RollMany(16, 0);
            Assert.That(24, Is.EqualTo(g.Score()));
        }
        
        [Test]
        public void TestOneStrikeAndOtherPins()
        {
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 1);
            Assert.That(40, Is.EqualTo(g.Score()));
        }
        
        [Test]
        public void TestPerfectGame()
        {
            RollMany(12,10);
            Assert.That(300, Is.EqualTo(g.Score()));
        }

        #region Some other unnecessary tests
        
        [Test]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.That(20, Is.EqualTo(g.Score()));
        }

        [Test]
        public void TestOneSpareAndOtherPins()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17, 1);
            Assert.That(33, Is.EqualTo(g.Score()));
        }

        [Test]
        public void TestTwoSpare()
        {
            RollSpare();
            g.Roll(3);
            g.Roll(0);
            RollSpare();
            g.Roll(7);
            g.Roll(0);
            RollMany(12, 0);
            Assert.That(40, Is.EqualTo(g.Score()));
        }

        [Test]
        public void TestTwoSpareAndOtherPins()
        {
            RollSpare();
            g.Roll(3);
            g.Roll(0);
            RollSpare();
            g.Roll(7);
            g.Roll(0);
            RollMany(12, 1);
            Assert.That(52, Is.EqualTo(g.Score()));
        }

        [Test]
        public void TestTwoStrike()
        {
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollStrike();
            g.Roll(5);
            g.Roll(8);
            RollMany(12, 0);
            Assert.That(60, Is.EqualTo(g.Score()));
        }

        [Test]
        public void TestTwoStrikeAndOtherPins()
        {
            RollStrike();
            RollStrike();
            RollStrike();
            RollMany(14, 1);
            Assert.That(77, Is.EqualTo(g.Score()));
        }

        [Test]
        public void TestTenthFrameWithoutBonus()
        {
            RollMany(18, 0);
            g.Roll(3);
            g.Roll(4);
            Assert.That(7, Is.EqualTo(g.Score()));
        }

        [TestCase(3, 7, 2, 12)]
        [TestCase(10, 0, 0, 10)]
        [TestCase(10, 1, 0, 11)]
        [TestCase(10, 1, 1, 12)]
        [TestCase(10, 10, 1, 21)]
        [TestCase(10, 10, 10, 30)]
        public void TestTenthFrameWithoutBonus(int pins4Roll19, int pins4Roll20, int pins4Roll21, int expected)
        {
            RollMany(18, 0);
            g.Roll(pins4Roll19);
            g.Roll(pins4Roll20);
            g.Roll(pins4Roll21);
            Assert.That(expected, Is.EqualTo(g.Score()));
        }

        #endregion
    }
}
