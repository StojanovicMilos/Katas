using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(33)]
        [InlineData(45)]
        [InlineData(99)]
        public void DividableByThreeContainsFizz(int numberDividableByThree)
        {
            //arrange
            string expectedSubstring = "Fizz";

            //act
            string output = Program.FizzBuzz(numberDividableByThree);

            //assert
            Assert.Contains(expectedSubstring, output);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(20)]
        [InlineData(45)]
        [InlineData(100)]
        public void DividableByFiveContainsBuzz(int numberDividableByFive)
        {
            //arrange
            string expectedSubstring = "Buzz";

            //act
            string output = Program.FizzBuzz(numberDividableByFive);

            //assert
            Assert.Contains(expectedSubstring, output);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        [InlineData(75)]
        [InlineData(90)]
        public void DividableByFifteenContainsBuzz(int numberDividableByFifteen)
        {
            //arrange
            string expectedOutput = "FizzBuzz";

            //act
            string output = Program.FizzBuzz(numberDividableByFifteen);

            //assert
            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(8)]
        [InlineData(46)]
        [InlineData(98)]
        public void NotDividableByThreeOrFiveContainsNumber(int numberNotDividableByThreeOrFive)
        {
            //arrange
            string expectedoutput = numberNotDividableByThreeOrFive.ToString();

            //act
            string output = Program.FizzBuzz(numberNotDividableByThreeOrFive);

            //assert
            Assert.Equal(expectedoutput, output);
        }

    }
}
