using System;

namespace ScoreKeeper
{
    class Program
    {
        static void Main()
        {
            const int initialScore = 0;
            ITeamScore homeTeamScore = new IntTeamScore(initialScore);
            INumber zero = new Number0();
            ITeamScore awayTeamScore = new NoPrimitivesTeamScore(zero, zero, zero);
            IScoreKeeper scoreKeeper = new ScoreKeeper(homeTeamScore, awayTeamScore);

            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA3();

            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB2();
            scoreKeeper.ScoreTeamB3();

            Console.WriteLine(scoreKeeper.GetScore());
        }
    }
}
