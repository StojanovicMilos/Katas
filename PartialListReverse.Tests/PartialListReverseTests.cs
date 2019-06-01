using System.Collections.Generic;
using Xunit;

namespace PartialListReverse.Tests
{
    public class PartialListReverseTests
    {
        public static IEnumerable<object[]> PartialListReverse
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[] {new List<char> { 'a', 'c', 'x', 'q', 'e', '2'}, 1, 6, new List<char> { '2', 'e', 'q', 'x', 'c', 'a' } },
                    new object[] {new List<char> { 'a', 'c', 'x', 'q', 'e', '2'}, 1, 2, new List<char> { 'c', 'a', 'x', 'q', 'e', '2' } },
                    new object[] {new List<char> { 'a', 'c', 'x', 'q', 'e', '2'}, 2, 4, new List<char> { 'a', 'q', 'x', 'c', 'e', '2'} }

                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(PartialListReverse))]
        public void PeriodFinderFindsCorrectPeriod<T>(List<T> list, int startIndex, int endIndex, List<T> expectedResult)
        {
            //arrange

            //act
            List<T> actualResult = PartialReverse.ReverseNodes(list, startIndex, endIndex);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
