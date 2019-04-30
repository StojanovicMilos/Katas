using ScoreKeeperTellDontAsk.Scoreboard;

namespace ScoreKeeperTellDontAsk.Tests
{
    public class TestingScoreboard : IScoreboard
    {
        public string DisplayedText { get; set; }

        public TestingScoreboard()
        {
            this.DisplayedText = string.Empty;
        }

        public void Display(string score)
        {
            DisplayedText += score;
        }
    }
}
