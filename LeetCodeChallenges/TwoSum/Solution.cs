using System;

namespace TwoSum
{
    //https://leetcode.com/problems/two-sum
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var num1 = nums[i];
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var num2 = nums[j];
                    if (num1 + num2 == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new Exception();
        }
    }
}
