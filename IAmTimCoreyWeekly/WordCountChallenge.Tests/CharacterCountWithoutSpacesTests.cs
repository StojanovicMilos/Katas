using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace WordCountChallenge.Tests
{
    public class CharacterCountWithoutSpacesTests
    {
        [Theory]
        [ClassData(typeof(CharacterCountWithoutSpacesTestData))]
        public void CharacterCountWithoutSpacesWorks(string text, int expectedWordCount)
        {
            Assert.Equal(expectedWordCount, WordsCalculator.CountCharactersWithoutSpaces(text));
        }
    }

    public class CharacterCountWithoutSpacesTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { WordCountChallengeSharedTestData.Tests[0], 60 };
            yield return new object[] { WordCountChallengeSharedTestData.Tests[1], 230 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
