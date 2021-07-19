using System.Collections.Generic;

namespace AddTwoNumbers.Tests
{
    public static class ListNodeExtensions
    {
        public static int[] ToArray(this ListNode listNode)
        {
            var result = new List<int>();
            while (listNode!=null)
            {
                result.Add(listNode.val);
                listNode = listNode.next;
            }

            return result.ToArray();
        }
    }
}