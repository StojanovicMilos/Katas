using Xunit;

namespace TennisGame.Tests
{
    public class TennisGameTest //: IClassFixture<TennisGameTestFixture>
    {
        //private TennisGame _tennisGame;

        [Fact]
        public void XunitWorks()
        {
            Assert.True(true);
        }

        //public TennisGameTest(TennisGame tennisGame)
        //{
        //    _tennisGame = tennisGame;
        //}

        [Fact]
        public void CanCreateGame()
        {
            Assert.NotNull(new TennisGame());
        }

        [Fact]
        public void NewGameLoveAll()
        {
            var tennisGame = new TennisGame();

            Assert.Equal("love all", tennisGame.GetScore());
        }

        [Fact]
        public void PlayerOneScorePoint15Love()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(1);

            Assert.Equal("15 love", tennisGame.GetScore());
        }

        [Fact]
        public void PlayerOneScoreTwoPoints30Love()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(2);

            Assert.Equal("30 love", tennisGame.GetScore());
        }

        [Fact]
        public void PlayerOneScoreThreePoints40Love()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(3);

            Assert.Equal("40 love", tennisGame.GetScore());
        }

        [Fact]
        public void PlayerTwoScoreOnePointLove15()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerTwoScore(1);

            Assert.Equal("love 15", tennisGame.GetScore());
        }

        [Fact]
        public void PlayerTwoScoreOnePointLove30()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerTwoScore(2);

            Assert.Equal("love 30", tennisGame.GetScore());
        }

        [Fact]
        public void BothScoreTwice()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(2);
            tennisGame.PlayerTwoScore(2);

            Assert.Equal("30 all", tennisGame.GetScore());
        }

        [Fact]
        public void DeuceThreePoints()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(3);
            tennisGame.PlayerTwoScore(3);

            Assert.Equal("deuce", tennisGame.GetScore());
        }

        [Fact]
        public void DeuceFourPoints()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(4);
            tennisGame.PlayerTwoScore(4);

            Assert.Equal("deuce", tennisGame.GetScore());
        }

        [Fact]
        public void DeuceFivePoints()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(5);
            tennisGame.PlayerTwoScore(5);

            Assert.Equal("deuce", tennisGame.GetScore());
        }

        [Fact]
        public void AdvantagePlayerOne()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(5);
            tennisGame.PlayerTwoScore(4);

            Assert.Equal("advantage player1", tennisGame.GetScore());
        }

        [Fact]
        public void AdvantagePlayerTwo()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(4);
            tennisGame.PlayerTwoScore(5);

            Assert.Equal("advantage player2", tennisGame.GetScore());
        }

        [Fact]
        public void WinnerPlayerOne()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(4);
            tennisGame.PlayerTwoScore(1);

            Assert.Equal("winner player1", tennisGame.GetScore());
        }

        [Fact]
        public void WinnerPlayerTwo()
        {
            var tennisGame = new TennisGame();

            tennisGame.PlayerOneScore(2);
            tennisGame.PlayerTwoScore(4);

            Assert.Equal("winner player2", tennisGame.GetScore());
        }
    }

    public static class TennisGameExtensions
    {
        public static void PlayerOneScore(this TennisGame tennisGame, int points)
        {
            for (int i = 0; i < points; i++)
            {
                tennisGame.PlayerOneScore();
            }
        }

        public static void PlayerTwoScore(this TennisGame tennisGame, int points)
        {
            for (int i = 0; i < points; i++)
            {
                tennisGame.PlayerTwoScore();
            }
        }
    }

    //public class TennisGameTestFixture : IDisposable
    //{
    //    public TennisGame TennisGame { get; private set; }

    //    public TennisGameTestFixture()
    //    {
    //        TennisGame = new TennisGame();
    //    }

    //    public void Dispose()
    //    {

    //    }
    //}
}
