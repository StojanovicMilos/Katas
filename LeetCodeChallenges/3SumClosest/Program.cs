// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//https://leetcode.com/problems/3sum-closest/submissions/1265878819/
Console.WriteLine(Solution.ThreeSumClosest([-1, 2, 1, -4], 1));

public static class Solution
{
    internal static int ThreeSumClosest(int[] nums, int target)
    {
        nums = nums.OrderBy(x => x).ToArray();
        int closest = int.MaxValue;
        int maxDif = int.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum == target)
                {
                    return sum;
                }
                int dif = Math.Abs(target - sum);
                if (dif < maxDif)
                {
                    closest = sum;
                    maxDif = dif;
                }

                if (sum > target)
                {
                    k--;
                }
                else
                {
                    j++;
                }
            }
        }

        return closest;
    }
}