using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace WordCountChallenge.Tests
{
    public class MostUsedWordTests
    {
        [Theory]
        [ClassData(typeof(MostUsedWordTestData))]
        public void MostUsedWordWorks(string text, string expectedWord, int expectedCount)
        {
            var result = WordsCalculator.GetMostUsedWord(text);

            Assert.Equal(expectedWord, result.Word);
            Assert.Equal(expectedCount, result.Count);
        }
    }

    public class MostUsedWordTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {WordCountChallengeSharedTestData.Tests[0], "the", 2 };
            yield return new object[] {WordCountChallengeSharedTestData.Tests[1], "the", 6 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
