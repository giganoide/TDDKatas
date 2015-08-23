using NUnit.Framework;
using TennisTdd;

namespace TennisGameTest
{
    [TestFixture]
    public class TennisGameTest
    {
        private TennisGame tennisGame;

        [SetUp]
        public void Setup()
        {
            tennisGame = new TennisGame();
        }

        [TestCase("1", "Fifteen-Love")]
        [TestCase("11", "Thirty-Love")]
        [TestCase("111", "Forty-Love")]
        [TestCase("1111", "Win for player1")]
        [TestCase("2", "Love-Fifteen")]
        [TestCase("22", "Love-Thirty")]
        [TestCase("222", "Love-Forty")]
        [TestCase("2222", "Win for player2")]
        [TestCase("12", "Fifteen-All")]
        [TestCase("21", "Fifteen-All")]
        [TestCase("121", "Thirty-Fifteen")]
        [TestCase("1211", "Forty-Fifteen")]
        [TestCase("111222", "Deuce")]
        [TestCase("1111222", "Advantage player1")]
        [TestCase("1112222", "Advantage player2")]
        [TestCase("11112222", "Deuce")]
        [TestCase("1111122222", "Deuce")]
        [TestCase("11111122222", "Advantage player1")]
        [TestCase("121212121211", "Win for player1")]
        public void ScoreTest(string points, string expected)
        {
            ScorePoints(points);
            Assert.AreEqual(expected,tennisGame.Score());
        }

        private void ScorePoints(string points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == '1')
                    tennisGame.PlayerOneScore();
                else
                    tennisGame.PlayerTwoScore();
            }
        }
    }
}
