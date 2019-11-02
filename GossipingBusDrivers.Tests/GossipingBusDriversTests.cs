using GossipingBusDrivers.BL;
using Xunit;

namespace GossipingBusDrivers.Tests
{
    public class GossipingBusDriversTests
    {
        [Theory]
        [InlineData("InputTextData\\Example1.txt", 5)]
        [InlineData("InputTextData\\Challenge1.txt", 9)]
        [InlineData("InputTextData\\Challenge2.txt", 16)]
        public void GossipingBusDriversExchangeAllGossipsAfter(string fileName, int expectedMinutes)
        {
            //arrange
            void OnSuccess(int minute) => Assert.Equal(expectedMinutes, minute);
            void OnFailure() => FailedTest();
            BusDrivers busDrivers = GossipingBusDriversInputReader.ReadDriversFrom(fileName);

            //act
            GossipingBusDriversAlgorithm.SolveForInput(busDrivers, OnSuccess, OnFailure);

            //assert

        }

        private void FailedTest() => Assert.True(false);
        private void SuccessfulTest() => Assert.True(true);

        [Fact]
        public void GossipingBusDriversNeverExchangeAllGossips()
        {
            //arrange
            void OnSuccess(int minute) => FailedTest();
            void OnFailure() => SuccessfulTest();
            BusDrivers busDrivers = GossipingBusDriversInputReader.ReadDriversFrom("InputTextData\\Example2.txt");

            //act
            GossipingBusDriversAlgorithm.SolveForInput(busDrivers, OnSuccess, OnFailure);

            //assert

        }
    }
}
