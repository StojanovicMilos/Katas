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

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
