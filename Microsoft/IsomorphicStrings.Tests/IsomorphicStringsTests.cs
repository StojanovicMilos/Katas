using System.Collections.Generic;
using Xunit;

namespace IsomorphicStrings.Tests
{
    public class IsomorphicStringsTests
    {
        public static IEnumerable<object[]> IsomorphicStringsTestData
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[] {"brain", "space", true},
                    new object[] {"noon", "feet", false},
                    new object[] {"aab", "ccd", true},
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(IsomorphicStringsTestData))]
        public void TestIsomorphicStrings(string a, string b, bool expectedResult)
        {
            //arrange

            //act
            bool actualResult = IsomorphicStringsChecker.AreStringsIsomorphic(a, b);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
