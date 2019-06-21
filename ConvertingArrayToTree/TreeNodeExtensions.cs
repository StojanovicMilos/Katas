using System.Collections.Generic;

namespace ConvertingArrayToTree
{
    public static class TreeNodeExtensions
    {
        public static int[] PreOrderTraversal(this TreeNode current) => current.ListPreOrderTraversal().ToArray();

        private static List<int> ListPreOrderTraversal(this TreeNode current)
        {
            List<int> result = new List<int>
            {
                current.Value
            };

            if (current.FirstChild != null)
            {
                result.AddRange(current.FirstChild.ListPreOrderTraversal());
            }

            if (current.Sibling != null)
            {
                result.AddRange(current.Sibling.ListPreOrderTraversal());
            }

            return result;
        }

        public static bool TreeSatisfiesRequirements(this TreeNode current)
        {
            bool evenNodeIsLeaf = current.Value % 2 == 0 && current.FirstChild == null;
            bool oddNodeIsInnerNode = current.Value % 2 != 0 && current.FirstChild != null;

            if (evenNodeIsLeaf || oddNodeIsInnerNode)
            {

                bool returnValue = true;
                if (current.FirstChild != null)
                    returnValue &= current.FirstChild.TreeSatisfiesRequirements();
                if (current.Sibling != null)
                    returnValue &= current.Sibling.TreeSatisfiesRequirements();

                return returnValue;
            }

            return false;
        }
    }
}
