using System.Collections.Generic;
using Xunit;

namespace ConvertingArrayToTree.Tests
{
    public class ConvertingArrayToTreeTests
    {
        public static IEnumerable<object[]> ConvertingArrayToTreeTestData
        {
            get
            {
                var list = new List<object[]>
                {
                    new object[] {new[] {3, 1, 4, 48, 2, 5, 3, 6, 18}},
                    new object[] {new[] {1, 6, 2, 1, 4, 3, 5, 7, 9, 8}}
                };
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        [Theory]
        [MemberData(nameof(ConvertingArrayToTreeTestData))]
        public void ConvertingArrayToTreeTest(int[] array)
        {
            //arrange

            //act
            TreeNode head = ArrayToTreeConverter.ConvertToTree(array);
            int[] preorder = head.PreOrderTraversal();

            //assert
            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], preorder[i]);
            }

            Assert.True(head.TreeSatisfiesRequirements());
        }
    }
}
