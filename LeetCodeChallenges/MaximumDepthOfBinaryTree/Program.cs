//https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
Console.WriteLine("Hello, World!");

public class Solution
{
    public int MaxDepth(TreeNode root) => MaxDepth(root, 0);

    private int MaxDepth(TreeNode node, int depth)
    {
        if (node == null)
        {
            return depth;
        }

        return Math.Max(MaxDepth(node.left, depth + 1), MaxDepth(node.right, depth + 1));
    }
}