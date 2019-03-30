using System;
using ScoreKeeperTellDontAsk.Score;
using ScoreKeeperTellDontAsk.Scoreboard;

namespace ScoreKeeperTellDontAsk.ScoreKeeper
{
    public class DefaultScoreKeeper : IScoreKeeper
    {
        private readonly ITeamScore _homeTeamScore;
        private readonly ITeamScore _awayTeamScore;

        private readonly IScoreboard _scoreboard;

        public DefaultScoreKeeper(ITeamScore homeScore, ITeamScore awayScore, IScoreboard scoreboard)
        {
            _homeTeamScore = homeScore;
            _awayTeamScore = awayScore;
            _scoreboard = scoreboard;
        }

        public void ScoreTeamA1()
        {
            _homeTeamScore.Score1();
            DisplayScore();
        }

        public void ScoreTeamA2()
        {
            _homeTeamScore.Score2();
            DisplayScore();
        }

        public void ScoreTeamA3()
        {
            _homeTeamScore.Score3();
            DisplayScore();
        }

        public void ScoreTeamB1()
        {
            _awayTeamScore.Score1();
            DisplayScore();
        }

        public void ScoreTeamB2()
        {
            _awayTeamScore.Score2();
            DisplayScore();
        }

        public void ScoreTeamB3()
        {
            _awayTeamScore.Score3();
            DisplayScore();
        }

        private void DisplayScore()
        {
            _homeTeamScore.Display();
            _scoreboard.Display(":");
            _awayTeamScore.Display();
            _scoreboard.Display(Environment.NewLine);
        }
    }
}
