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

        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.That(g.Score(), Is.EqualTo(0));
        }
        
        [Test]
        public void TestAllOnes()
        {
            RollMany(20,1);
            Assert.That(g.Score(), Is.EqualTo(20));
        }

        [Test]
        [Ignore]
        public void TestOneSpare()
        {
            g.Roll(5);
            g.Roll(5); // spare
            g.Roll(3);
            RollMany(17,0);
            Assert.That(g.Score(), Is.EqualTo(16));
        }

    }
}
