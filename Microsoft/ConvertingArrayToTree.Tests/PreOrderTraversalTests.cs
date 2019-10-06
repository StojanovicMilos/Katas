using System.Collections.Generic;
using Xunit;

namespace ConvertingArrayToTree.Tests
{
    public class PreOrderTraversalTests
    {
        public static IEnumerable<object[]> PreOrderTraversalTestData
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[]
                    {
                        new TreeNode
                        {
                            Value = 3,
                            FirstChild = new TreeNode
                            {
                                Value = 1,
                                FirstChild = new TreeNode
                                {
                                    Value = 4,
                                    Sibling = new TreeNode
                                    {
                                        Value = 48
                                    }
                                },
                                Sibling = new TreeNode
                                {
                                    Value = 2,
                                    Sibling = new TreeNode
                                    {
                                        Value = 5,
                                        FirstChild = new TreeNode
                                        {
                                            Value = 3,
                                            FirstChild = new TreeNode
                                            {
                                                Value = 6,
                                                Sibling = new TreeNode()
                                                {
                                                    Value = 18
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        },
                        new[] {3, 1, 4, 48, 2, 5, 3, 6, 18}
                    },

                    new object[]
                    {
                        new TreeNode
                        {
                            Value = 6,
                            FirstChild = new TreeNode
                            {
                                Value = 2,
                                FirstChild = new TreeNode
                                {
                                    Value = 1,
                                    Sibling = new TreeNode
                                    {
                                        Value = 4,
                                        FirstChild = new TreeNode
                                        {
                                            Value = 3,
                                            Sibling = new TreeNode
                                            {
                                                Value = 5
                                            }
                                        }
                                    }
                                },
                                Sibling = new TreeNode
                                {
                                    Value = 7,
                                    FirstChild = new TreeNode
                                    {
                                        Value = 9,
                                        FirstChild = new TreeNode
                                            {Value = 8}

                                    }
                                }
                            }
                        },
                        new[] {6, 2, 1, 4, 3, 5, 7, 9, 8}
                    }
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(PreOrderTraversalTestData))]
        public void PreOrderTraversalTest(TreeNode head, int[] expectedResult)
        {
            //arrange

            //act
            int[] actualResult = head.PreOrderTraversal();

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], actualResult[i]);
            }
        }
    }
}
