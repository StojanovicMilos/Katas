using System;

namespace ScoreKeeperTellDontAsk.Scoreboard
{
    public class ConsoleScoreboard : IScoreboard
    {
        public void Display(string score) => Console.Write(score);
    }
}
