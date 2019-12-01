using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace WordCountChallenge.Tests
{
    public class WordCountTests
    {
        [Theory]
        [ClassData(typeof(WordCountTestData))]
        public void WordCountWorks(string text, int expectedWordCount)
        {
            Assert.Equal(expectedWordCount, WordsCalculator.CountTotalWords(text));
        }
    }

    public class WordCountTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { WordCountChallengeSharedTestData.Tests[0], 14 };
            yield return new object[] { WordCountChallengeSharedTestData.Tests[1], 45 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}