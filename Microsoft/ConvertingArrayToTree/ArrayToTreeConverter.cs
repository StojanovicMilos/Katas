using System;
using System.Linq;

namespace ConvertingArrayToTree
{
    public static class ArrayToTreeConverter
    {
        public static TreeNode ConvertToTree(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(array));

            TreeNode root = new TreeNode {Value = array[0]};

            TreeNode currentNode = root;
            foreach (var value in array.Skip(1))
            {
                if (currentNode.Value % 2 == 0)
                {
                    currentNode.Sibling = new TreeNode {Value = value};
                    currentNode = currentNode.Sibling;
                }
                else
                {
                    currentNode.FirstChild = new TreeNode {Value = value};
                    currentNode = currentNode.FirstChild;
                }
            }

            return root;
        }
    }
}
