using System;
using ScoreKeeperTellDontAsk.Score;
using ScoreKeeperTellDontAsk.Scoreboard;
using ScoreKeeperTellDontAsk.ScoreKeeper;
using Xunit;

namespace ScoreKeeperTellDontAsk.Tests
{
    public class ScoreKeeperTellDontAskTests
    {
        [Fact]
        public void ScoreKeeperDisplaysRightResult()
        {
            //arrange
            const int initialScore = 0;
            IScoreboard scoreboard = new TestingScoreboard();
            ITeamScore homeTeamScore = new IntTeamScore(initialScore, scoreboard);
            ITeamScore awayTeamScore = new IntTeamScore(initialScore, scoreboard);
            IScoreKeeper scoreKeeper = new DefaultScoreKeeper(homeTeamScore, awayTeamScore, scoreboard);
            string expectedResult = "003:000" + Environment.NewLine;

            //act
            scoreKeeper.ScoreTeamA3();

            //assert
            Assert.Equal(expectedResult, ((TestingScoreboard) scoreboard).DisplayedText);
        }
    }
}
