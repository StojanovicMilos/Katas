using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace WordCountChallenge.Tests
{
    public class CharacterCountTests
    {
        [Theory]
        [ClassData(typeof(CharacterCountTestData))]
        public void CharacterCountWorks(string text, int expectedWordCount)
        {
            Assert.Equal(expectedWordCount, WordsCalculator.CountTotalCharacters(text));
        }
    }

    public class CharacterCountTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { WordCountChallengeSharedTestData.Tests[0], 89 };
            yield return new object[] { WordCountChallengeSharedTestData.Tests[1], 276 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
