using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqWeeklyChallenge.Tests
{
    public class LinqWeeklyChallengeTests
    {
        public static IEnumerable<object[]> LinqTestData
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[]
                    {
                        "Create a LINQ query that takes in a string and returns a list of all the letters in order, regardless of case",
                        new[]
                        {
                            new ReturnObject {Char = ' ', Count = 21},
                            new ReturnObject {Char = 'e', Count = 12},
                            new ReturnObject {Char = 'a', Count = 10},
                            new ReturnObject {Char = 'r', Count = 10},
                            new ReturnObject {Char = 't', Count = 10},
                            new ReturnObject {Char = 's', Count = 8},
                            new ReturnObject {Char = 'l', Count = 6},
                            new ReturnObject {Char = 'n', Count = 6},
                            new ReturnObject {Char = 'i', Count = 5},
                            new ReturnObject {Char = 'd', Count = 3},
                            new ReturnObject {Char = 'o', Count = 3},
                            new ReturnObject {Char = 'c', Count = 2},
                            new ReturnObject {Char = 'f', Count = 2},
                            new ReturnObject {Char = 'g', Count = 2},
                            new ReturnObject {Char = 'h', Count = 2},
                            new ReturnObject {Char = 'q', Count = 2},
                            new ReturnObject {Char = 'u', Count = 2},
                            new ReturnObject {Char = ',', Count = 1},
                            new ReturnObject {Char = 'k', Count = 1},
                            new ReturnObject {Char = 'y', Count = 1}
                        }
                    }
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(LinqTestData))]
        public void ConvertToObjectListTest(string data, ReturnObject[] expectedArray)
        {
            //arrange

            //act
            var result = data.ConvertToObjectList().ToArray();

            //assert
            Assert.Equal(expectedArray.Length, result.Length);
            for (int i = 0; i < expectedArray.Length; i++)
            {
                ReturnObject expected = expectedArray[i];
                ReturnObject actual = result[i];

                Assert.Equal(expected.Char, actual.Char);
                Assert.Equal(expected.Count, actual.Count);
            }
        }
    }
}
