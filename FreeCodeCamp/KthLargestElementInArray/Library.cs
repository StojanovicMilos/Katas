namespace KthLargestElementInArray
{
    public static class Library
    {
        public static int FindLargestElementV1(int[] array, int k)
        {
            var item = array.OrderByDescending(element => element).Skip(k - 1).FirstOrDefault();
            return item == default ? throw new InvalidOperationException() : item;
        }

        public static int FindLargestElementV2(int[] array, int k)
        {
            if(k > array.Length || k == 0)
            {
                throw new InvalidOperationException();
            }

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(array.Length);
            foreach (var item in array)
            {
                queue.Enqueue(item, -item);
            }

            for (int i = 0; i < k-1; i++)
            {
                _ = queue.Dequeue();
            }

            return queue.Dequeue();
        }
    }
}
