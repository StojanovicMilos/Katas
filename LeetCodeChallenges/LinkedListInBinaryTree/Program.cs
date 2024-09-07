//https://leetcode.com/problems/linked-list-in-binary-tree/description/?envType=daily-question&envId=2024-09-07
Console.WriteLine("Hello, World!");

public class Solution
{
    public bool IsSubPath(ListNode head, TreeNode root)
    {
        if (root == null)
        {
            return false;
        }

        if (head == null)
        {
            return true;
        }

        return DFS(root, head);
    }

    private bool DFS(TreeNode node, ListNode listNode)
    {
        if (node == null)
        {
            return false;
        }

        if (listNode == null)
        {
            return true;
        }

        if (node.val == listNode.val && IsPath(node, listNode))
            return true;

        return DFS(node.left, listNode) || DFS(node.right, listNode);
    }

    private bool IsPath(TreeNode node, ListNode listNode)
    {
        if (listNode == null)
        {
            return true;
        }

        if (node == null)
        {
            return false;
        }

        if (node.val != listNode.val)
        {
            return false;
        }

        return IsPath(node.left, listNode.next) || IsPath(node.right, listNode.next);
    }
}