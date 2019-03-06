using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void XunitWorks()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void MapReturnsNumber(int number, string expectedResult)
        {
            //arrange
            var mappingStrategies = new IMappingStrategy[] { };
            IMappingStrategy mappingStrategy = new CompositeMappingStrategy(mappingStrategies);

            //act
            string result = mappingStrategy.Map(number);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        public void MapReturnsFizzForNumberDividableByThree(int number, string expectedResult)
        {
            //arrange
            var dividableByThreeMappingStrategy = new DividableByThreeMappingStrategy();

            //act
            string result = dividableByThreeMappingStrategy.Map(number);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        public void MapReturnsBuzzForNumberDividableByFive(int number, string expectedResult)
        {
            //arrange
            var dividableByFiveMappingStrategy = new DividableByFiveMappingStrategy();

            //act
            string result = dividableByFiveMappingStrategy.Map(number);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(90, "FizzBuzz")]
        public void MapReturnsFizzBuzzForNumberDividableByFifteen(int number, string expectedResult)
        {
            //arrange
            var mappingStrategies = new IMappingStrategy[] { new DividableByThreeMappingStrategy(), new DividableByFiveMappingStrategy() };
            IMappingStrategy mappingStrategy = new CompositeMappingStrategy(mappingStrategies);

            //act
            string result = mappingStrategy.Map(number);

            //assert
            Assert.Equal(expectedResult, result);
        }
    }
}
