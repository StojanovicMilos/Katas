using System.Collections.Generic;
using Xunit;

namespace PeriodOfArray.Tests
{
    public class PeriodOfArrayTests
    {
        public static IEnumerable<object[]> PeriodOfArrayTestData
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[] {new[] {2, 5, 3, 4, 2, 5, 3, 4}, 4},
                    new object[] {new[] {3, 5, 3, 2, 5, 3, 2, 5}, 8},
                    new object[] {new[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 2}, 10},
                    new object[] {new int[] {}, 0},
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(PeriodOfArrayTestData))]
        public void PeriodFinderFindsCorrectPeriod(int[] array, int expectedPeriod)
        {
            //arrange

            //act
            int actualPeriod = PeriodFinder.FindMinimumPeriod(array);

            //assert
            Assert.Equal(expectedPeriod, actualPeriod);
        }
    }
}
