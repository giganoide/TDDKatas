using System;
using NUnit.Framework;

namespace Tennis
{
    internal class TennisGame1 : TennisGame
    {
        private int scorePlayerOne = 0;
        private int scorePlayerTwo = 0;
        private string player1Name;
        private string player2Name;

        private bool isFinalScore
        {
            get { return scorePlayerOne >= 4 || scorePlayerTwo >= 4; }
        }

        private bool isScoreEqual
        {
            get { return scorePlayerOne == scorePlayerTwo; }
        }

        private int diffScore
        {
            get { return scorePlayerOne - scorePlayerTwo; }
        }

        private bool IsAdvP1
        {
            get { return diffScore == 1; }
        }

        private bool IsAdvP2
        {
            get { return diffScore == -1; }
        }

        private bool IsWinP1
        {
            get { return diffScore >= 2; }
        }

        private bool IsWinP2
        {
            get { return diffScore <= 2; }
        }

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName.Equals(player1Name))
                scorePlayerOne ++;
            if (playerName.Equals(player2Name))
                scorePlayerTwo ++;
        }

        public string GetScore()
        {
            if (isScoreEqual)
                return GetEqualScore(scorePlayerOne);
            if (isFinalScore)
                return GetFinalScore(scorePlayerOne, scorePlayerTwo);
            return GetStandardScore(scorePlayerOne, scorePlayerTwo);
        }

        private string GetFinalScore(int score1, int score2)
        {
            if (IsAdvP1) 
                return "Advantage player1";
            if (IsAdvP2) 
                return "Advantage player2";
            if (IsWinP1) 
                return "Win for player1";
            if (IsWinP2) 
                return "Win for player2";
            return String.Empty;
        }

        private string GetStandardScore(int score1, int score2)
        {
            return string.Format("{0}-{1}", GetPoint(score1), GetPoint(score2));
        }

        private static string GetPoint(int score)
        {
            string[] descScore = { "Love", "Fifteen", "Thirty", "Forty"};
            return descScore[score];
        }

        private string GetEqualScore(int score)
        {
            if (score > 2)
                return "Deuce";
            return GetPoint(score) + "-All";
        }
    }

}

