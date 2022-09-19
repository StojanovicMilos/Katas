//215. Kth Largest Element in an Array https://leetcode.com/problems/kth-largest-element-in-an-array/

using KthLargestElementInArray;
using Xunit;

namespace KthLargestElementInArrayTests
{
    public class LibraryTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, 1, 1)]
        [InlineData(new int[] { 1, 2 }, 1, 2)]
        [InlineData(new int[] { 1, 2 }, 2, 1)]
        [InlineData(new int[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        [InlineData(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
        public void AddWorksCorrectly(int[] array, int k, int expected)
        {
            var result = Library.FindLargestElementV2(array, k);

            Assert.Equal(expected, result);
        }
    }
}