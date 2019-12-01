using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace WordCountChallenge.Tests
{
    public class MostUsedCharacterTests
    {
        [Theory]
        [ClassData(typeof(MostUsedCharacterTestData))]
        public void MostUsedCharacterWorks(string text, char expectedChar, int expectedCount)
        {
            var result = WordsCalculator.GetMostUsedChar(text);

            Assert.Equal(expectedChar, result.Char);
            Assert.Equal(expectedCount, result.Count);
        }
    }

    public class MostUsedCharacterTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { WordCountChallengeSharedTestData.Tests[0], "e", 10 };
            yield return new object[] { WordCountChallengeSharedTestData.Tests[1], "t", 24 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
