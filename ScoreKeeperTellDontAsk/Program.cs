using ScoreKeeperTellDontAsk.Score;
using ScoreKeeperTellDontAsk.Scoreboard;
using ScoreKeeperTellDontAsk.ScoreKeeper;

namespace ScoreKeeperTellDontAsk
{
    class Program
    {
        static void Main()
        {
            const int initialScore = 0;
            IScoreboard scoreboard = new ConsoleScoreboard();
            ITeamScore homeTeamScore = new IntTeamScore(initialScore, scoreboard);
            ITeamScore awayTeamScore = new IntTeamScore(initialScore, scoreboard);
            IScoreKeeper scoreKeeper = new DefaultScoreKeeper(homeTeamScore, awayTeamScore, scoreboard);

            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA3();

            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB2();
            scoreKeeper.ScoreTeamB3();
        }
    }
}
