using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace WordWrap.Tests
{
    public class WordWrapTest
    {
        [Fact]
        public void WordWrapTestsWork()
        {
            Assert.True(true);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[] { "  ", 10, "  " },
                    new object[] { "abc def", 3, $"abc{Environment.NewLine}def" },
                    new object[] { "abc def", 4, $"abc{Environment.NewLine}def" }
                };

                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void HappyPath(string input, int index, string expectedOutput)
        {


            var result = Wrapper.Wrap(input, index);

            Assert.Equal(expectedOutput, result);
        }
    }
}
