// https://leetcode.com/problems/merge-k-sorted-lists/description/
Console.WriteLine("Hello, World!");

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var minHeap = new PriorityQueue<ListNode, int>();

        for (int i = 0; i < lists.Length; i++)
        {
            if (lists[i] != null)
            {
                minHeap.Enqueue(lists[i], lists[i].val);
            }
        }

        var dummy = new ListNode(0);
        var current = dummy;

        while (minHeap.Count > 0)
        {
            var node = minHeap.Dequeue();

            current.next = node;
            current = current.next;

            if (node.next != null)
            {
                minHeap.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}