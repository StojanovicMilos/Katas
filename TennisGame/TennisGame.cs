using System;
using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame
    {
        private int _playerOneScore;
        private int _playerTwoScore;

        private static readonly Dictionary<int, string> PointToString = new Dictionary<int, string>
        {
            {0, "love" },
            {1, "15"},
            {2, "30"},
            {3, "40"}
        };

        public TennisGame()
        {
            _playerOneScore = 0;
            _playerTwoScore = 0;
        }

        public IEnumerable<char> GetScore()
        {
            if (GameOver)
                return $"winner {LeadingPlayer}";

            if (IsTie)
            {
                if (_playerOneScore >= 3)
                {
                    return "deuce";
                }

                {
                    return $"{PointToString[_playerTwoScore]} all";
                }
            }

            if (IsAdvantage)
            {
                return $"advantage {LeadingPlayer}";
            }

            return $"{PointToString[_playerOneScore]} {PointToString[_playerTwoScore]}";

        }

        private string LeadingPlayer => $"player{(_playerOneScore > _playerTwoScore ? 1 : 2)}";

        private bool GameOver => (_playerOneScore > 3 || _playerTwoScore > 3) && (Math.Abs(_playerOneScore - _playerTwoScore) >= 2);

        private bool IsTie => _playerOneScore == _playerTwoScore;

        private bool IsAdvantage => _playerOneScore > 3 && _playerTwoScore > 3 && _playerOneScore != _playerTwoScore;

        public void PlayerOneScore() => _playerOneScore++;

        public void PlayerTwoScore() => _playerTwoScore++;
    }
}