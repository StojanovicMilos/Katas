namespace ScoreKeeper
{
    public class IntTeamScore : ITeamScore
    {
        private int _score;

        public IntTeamScore(int score)
        {
            _score = score;
        }

        private const int MaxScore = 1000;

        public void Score1() => _score = (_score + 1) % MaxScore;
        public void Score2() => _score = (_score + 2) % MaxScore;
        public void Score3() => _score = (_score + 3) % MaxScore;

        public override string ToString() => _score.ToString().PadLeft(3, '0');
    }
}