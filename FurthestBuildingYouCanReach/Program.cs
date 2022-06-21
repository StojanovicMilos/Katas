namespace FurthestBuildingYouCanReach // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var array = new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 };
            int bricks = 10;
            int ladders = 2;

            Console.WriteLine(FurthestBuilding(array, bricks, ladders));
        }

        public static int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            if (heights == null || heights.Length == 0)
            {
                return 0;
            }

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            for (int i = 0; i < heights.Length - 1; i++)
            {
                int diff = heights[i + 1] - heights[i];
                if (diff <= 0)
                {
                    continue;
                }

                queue.Enqueue(diff, -diff);
                bricks -= diff;

                if (bricks < 0)
                {
                    if (ladders == 0)
                    {
                        return i;
                    }

                    bricks += queue.Dequeue();
                    ladders--;
                }
            }

            return heights.Length - 1;
        }
    }
}