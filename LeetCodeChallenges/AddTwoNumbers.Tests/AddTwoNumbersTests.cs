using Xunit;

namespace AddTwoNumbers.Tests
{
    public class AddTwoNumbersTests
    {
        [Theory]
        [InlineData(new[] { 0, 8, 6, 5, 6, 8, 3, 5, 7 }, new[] { 6, 7, 8, 0, 8, 5, 8, 9, 7 }, new[] { 6, 5, 5, 6, 4, 4, 2, 5, 5, 1 })]
        public void HappyPath(int[] array1, int[] array2, int[] expectedOutput)
        {
            var l1 = ListNodeFactory.From(array1);
            var l2 = ListNodeFactory.From(array2);
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(l1, l2);

            Assert.Equal(expectedOutput, actual.ToArray());
        }
    }
}