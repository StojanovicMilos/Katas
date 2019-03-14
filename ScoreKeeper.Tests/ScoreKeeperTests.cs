using Xunit;

namespace ScoreKeeper.Tests
{
    public class ScoreKeeperTests
    {
        private readonly ScoreKeeper _scoreKeeper;

        public ScoreKeeperTests()
        {
            const int initialScore = 0;
            var homeTeamScore = new IntTeamScore(initialScore);
            INumber zero = new Number0();
            ITeamScore awayTeamScore = new NoPrimitivesTeamScore(zero, zero, zero);
            _scoreKeeper = new ScoreKeeper(homeTeamScore, awayTeamScore);
        }

        [Fact]
        public void ScoreKeeperTestsWork()
        {
            Assert.True(true);
        }

        [Fact]
        public void ScoreKeeperInitialValueIsCorrect()
        {
            //arrange
            const string expectedInitialResult = "000:000";

            //act
            var actualInitialResult = _scoreKeeper.GetScore();

            //assert
            Assert.Equal(expectedInitialResult, actualInitialResult);
        }

        [Fact]
        public void ScoreKeeperTeamAScores()
        {
            //arrange
            const string expectedResult = "001:000";

            //act
            _scoreKeeper.ScoreTeamA1();
            var actualResult = _scoreKeeper.GetScore();

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ScoreKeeperKeepsScore()
        {
            //arrange
            const string expectedResult = "600:600";

            //act
            for (int i = 0; i < 100; i++)
            {
                _scoreKeeper.ScoreTeamA1();
                _scoreKeeper.ScoreTeamA2();
                _scoreKeeper.ScoreTeamA3();

                _scoreKeeper.ScoreTeamB1();
                _scoreKeeper.ScoreTeamB2();
                _scoreKeeper.ScoreTeamB3();
            }

            var actualResult = _scoreKeeper.GetScore();

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
