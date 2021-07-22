using System;
using System.Linq;

namespace PartitionArrayIntoDisjointIntervals
{
    //https://leetcode.com/explore/challenge/card/july-leetcoding-challenge-2021/611/week-4-july-22nd-july-28th/3823/
    public class Solution
    {
        public int PartitionDisjoint(int[] nums)
        {
            int[] maxLeft = new int[nums.Length];
            var minRight = new int[nums.Length];

            maxLeft[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxLeft[i] = Math.Max(nums[i], maxLeft[i - 1]);
            }

            minRight[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                minRight[i] = Math.Min(nums[i], minRight[i + 1]);
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (maxLeft[i] <= minRight[i + 1])
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
