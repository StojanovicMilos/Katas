namespace AddTwoNumbers
{
    //https://leetcode.com/problems/add-two-numbers
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sum = l1.val + l2.val;
            var head = new ListNode(sum % 10);
            var carryover = sum / 10;
            var currentListNode = head;

            while (l1?.next != null || l2?.next != null || carryover != 0)
            {
                l1 = l1?.next;
                l2 = l2?.next;
                sum = Add(l1, l2, carryover);
                carryover = sum / 10;
                sum = sum % 10;

                currentListNode.next = new ListNode(sum);
                currentListNode = currentListNode.next;
            }

            return head;
        }

        private static int Add(ListNode l1, ListNode l2, int carryover)
        {
            if (l1 == null && l2 == null)
            {
                return carryover;
            }

            if (l1 == null)
            {
                return l2.val + carryover;
            }

            if (l2 == null)
            {
                return l1.val + carryover;
            }

            return l1.val + l2.val + carryover;
        }
    }
}
