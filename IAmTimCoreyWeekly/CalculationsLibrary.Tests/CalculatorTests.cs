using System;
using Xunit;

namespace CalculationsLibrary.Tests
{
    public class CalculatorTests
    {
        [InlineData(1,2)]
        [InlineData(100, 200)]
        [InlineData(5, 6)]
        [Theory]
        public void AddWorksCorrectly(double addend1, double addend2)
        {
            double expectedResult = addend1 + addend2;

            double result = Calculator.Add(addend1, addend2);

            Assert.Equal(expectedResult, result);
        }

        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(1000)]
        [InlineData(-500)]
        [Theory]
        public void CantDivideByZero(double dividend)
        {
            const double divisor = 0;

            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculator.Divide(dividend, divisor));

            Assert.Equal("Cannot divide by zero", ex.Message);
        }

        [InlineData(1, 2)]
        [InlineData(100, 200)]
        [InlineData(5, 6)]
        [Theory]
        public void DivisionWorksCorrectly(double dividend, double divisor)
        {
            double expectedResult = dividend / divisor;

            double result = Calculator.Divide(dividend, divisor);

            Assert.Equal(expectedResult, result);
        }
    }
}
