using ScoreKeeperTellDontAsk.Scoreboard;

namespace ScoreKeeperTellDontAsk.Tests
{
    public class TestingScoreboard : IScoreboard
    {
        public string DisplayedText { get; set; }

        public TestingScoreboard()
        {
            DisplayedText = string.Empty;
        }

        public void Display(string score)
        {
            DisplayedText += score;
        }
    }
}
