using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisTdd
{
    public class TennisGame
    {
        private int playerOneScore;
        private int playerTwoScore;

        public void PlayerOneScore()
        {
            playerOneScore++;
        }

        public void PlayerTwoScore()
        {
            playerTwoScore++;
        }

        public string Score()
        {
            if (playerOneScore >= 3 && playerTwoScore >= 3 && playerOneScore == playerTwoScore)
                return "Deuce";
            if (playerOneScore >= 4 && playerTwoScore >= 3 && playerOneScore - playerTwoScore == 1)
                return "Advantage player1";
            if (playerOneScore >= 3 && playerTwoScore >= 4 && playerOneScore - playerTwoScore == -1)
                return "Advantage player2";
            if (playerOneScore >= 4)
                return "Win for player1";
            if (playerTwoScore >= 4)
                return "Win for player2";
            if (playerOneScore == playerTwoScore)
                return GetScore(playerOneScore) + "-All";
            return String.Format("{0}-{1}", GetScore(playerOneScore), GetScore(playerTwoScore));
        }

        public string GetScore(int score)
        {
            string[] descScore = { "Love", "Fifteen", "Thirty", "Forty" };
            if (score > 3)
                return string.Empty;
            return descScore[score];
        }

        
    }
}
