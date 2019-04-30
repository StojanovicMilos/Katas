using ScoreKeeperTellDontAsk.Scoreboard;

namespace ScoreKeeperTellDontAsk.Score
{
    public class IntTeamScore : ITeamScore
    {
        private int _score;
        private readonly IScoreboard _scoreboard;

        public IntTeamScore(int score, IScoreboard scoreboard)
        {
            _score = score;
            _scoreboard = scoreboard;
        }

        private const int MaxScore = 1000;

        public void Score1() => _score = (_score + 1) % MaxScore;
        public void Score2() => _score = (_score + 2) % MaxScore;
        public void Score3() => _score = (_score + 3) % MaxScore;

        public void Display() => _scoreboard.Display(_score.ToString().PadLeft(3, '0'));

        //public override string ToString() => _score.ToString().PadLeft(3, '0');


    }
}