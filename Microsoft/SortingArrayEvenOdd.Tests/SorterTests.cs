using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace SortingArrayEvenOdd.Tests
{
    public class SorterTests
    {
        public static IEnumerable<object[]> Data
        {
            // ReSharper disable once UnusedMember.Global
            get
            {
                yield return new object[] { new[] { 1, 2 } };
                yield return new object[] { new[] { 1, 4 } };
                yield return new object[] { new[] { 3, 2 } };
                yield return new object[] { new[] { 1, 3, 2 } };
                yield return new object[] { new[] { 1, 3, 2, 4 } };
                yield return new object[] { new[] { 1, 3, 2, 5, 4 } };
            }
        }

        [MemberData(nameof(Data))]
        [Theory]
        public void HappyPath(int[] input)
        {
            Sorter.Sort(input);

            Assert.True(ArrayHelper.ArrayIsSorted(input));
        }
    }
}
