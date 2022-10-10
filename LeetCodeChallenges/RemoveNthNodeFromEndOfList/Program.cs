//https://leetcode.com/problems/remove-nth-node-from-end-of-list/

var list = new ListNode(0,
    new ListNode(1,
    new ListNode(2,
    new ListNode(3,
    new ListNode(4,
    new ListNode(5,
    new ListNode(6,
    new ListNode(7))))))));

list = list.RemoveNodeFromEndOfList(1);

var node = list;
while (node != null)
{
    Console.WriteLine(node.val);
    node = node.next;
}

public static class Extensions
{
    public static ListNode RemoveNodeFromEndOfList(this ListNode head, int n)
    {
        var circularBuffer = new ListNode[n + 1];
        int index = 0;
        var node = head;
        while (node != null)
        {
            circularBuffer[index] = node;
            index = (index + 1) % circularBuffer.Length;
            node = node.next;
        }

        var previous = circularBuffer[index % circularBuffer.Length];
        var toBeRemoved = circularBuffer[(index + 1) % circularBuffer.Length];
        var next = circularBuffer[(index + 2) % circularBuffer.Length];
        if (previous != null)
        {
            previous.next = previous != next ? next : null;
        }
        else
        {
            head = next;
        }

        return head;
    }
}