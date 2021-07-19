using System;

namespace AddTwoNumbers.Tests
{
    public static class ListNodeFactory
    {
        public static ListNode From(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(array));

            ListNode head = new ListNode(array[0]);
            var current = head;

            for (int i = 1; i < array.Length; i++)
            {
                current.next = new ListNode(array[i]);
                current = current.next;
            }

            return head;
        }
    }
}