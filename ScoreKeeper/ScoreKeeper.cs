namespace ScoreKeeper
{
    public class ScoreKeeper : IScoreKeeper
    {
        private readonly ITeamScore _homeTeamScore;
        private readonly ITeamScore _awayTeamScore;

        public ScoreKeeper(ITeamScore homeScore, ITeamScore awayScore)
        {
            _homeTeamScore = homeScore;
            _awayTeamScore = awayScore;
        }

        public void ScoreTeamA1() => _homeTeamScore.Score1();
        public void ScoreTeamA2() => _homeTeamScore.Score2();
        public void ScoreTeamA3() => _homeTeamScore.Score3();

        public void ScoreTeamB1() => _awayTeamScore.Score1();
        public void ScoreTeamB2() => _awayTeamScore.Score2();
        public void ScoreTeamB3() => _awayTeamScore.Score3();

        public string GetScore() => _homeTeamScore + ":" + _awayTeamScore;
    }
}
