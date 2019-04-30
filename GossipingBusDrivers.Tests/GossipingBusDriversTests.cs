using GossipingBusDrivers.BL;
using Xunit;

namespace GossipingBusDrivers.Tests
{
    public class GossipingBusDriversTests
    {
        [Fact]
        public void GossipingBusDriversExample1()
        {
            //arrange
            const int expectedMinutes = 5;
            void OnSuccess(int minute) => Assert.Equal(expectedMinutes, minute);
            void OnFailure() => Assert.True(false);
            GossipingBusDriversInputReader reader = new GossipingBusDriversInputReader();
            GossipingBusDriversAlgorithm gossipingBusDrivers = new GossipingBusDriversAlgorithm(reader);

            //act
            gossipingBusDrivers.SolveForInput("InputTextData\\Example1.txt", OnSuccess, OnFailure);

            //assert

        }

        [Fact]
        public void GossipingBusDriversExample2()
        {
            //arrange
            void OnSuccess(int minute) => Assert.True(false);
            void OnFailure() => Assert.True(true);
            GossipingBusDriversInputReader reader = new GossipingBusDriversInputReader();
            GossipingBusDriversAlgorithm gossipingBusDrivers = new GossipingBusDriversAlgorithm(reader);

            //act
            gossipingBusDrivers.SolveForInput("InputTextData\\Example2.txt", OnSuccess, OnFailure);

            //assert

        }

        [Fact]
        public void GossipingBusDriversChallenge1()
        {
            //arrange
            const int expectedMinutes = 9;
            void OnSuccess(int minute) => Assert.Equal(expectedMinutes, minute);
            void OnFailure() => Assert.True(false);
            GossipingBusDriversInputReader reader = new GossipingBusDriversInputReader();
            GossipingBusDriversAlgorithm gossipingBusDrivers = new GossipingBusDriversAlgorithm(reader);

            //act
            gossipingBusDrivers.SolveForInput("InputTextData\\Challenge1.txt", OnSuccess, OnFailure);

            //assert

        }

        [Fact]
        public void GossipingBusDriversChallenge2()
        {
            //arrange
            const int expectedMinutes = 16;
            void OnSuccess(int minute) => Assert.Equal(expectedMinutes, minute);
            void OnFailure() => Assert.True(false);
            GossipingBusDriversInputReader reader = new GossipingBusDriversInputReader();
            GossipingBusDriversAlgorithm gossipingBusDrivers = new GossipingBusDriversAlgorithm(reader);

            //act
            gossipingBusDrivers.SolveForInput("InputTextData\\Challenge2.txt", OnSuccess, OnFailure);

            //assert

        }
    }
}
