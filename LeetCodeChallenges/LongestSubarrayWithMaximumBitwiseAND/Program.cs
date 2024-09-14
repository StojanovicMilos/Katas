//https://leetcode.com/problems/longest-subarray-with-maximum-bitwise-and/description/
Console.WriteLine("Hello, World!");

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        var result = 0;
        if (nums == null || nums.Length == 0)
        {
            return result;
        }

        var max = nums.Max();
        var currentLength = 0;
        foreach (int num in nums)
        {
            if (num == max)
            {
                currentLength++;
                if (currentLength > result)
                {
                    result = currentLength;
                }
            }
            else
            {
                currentLength = 0;
            }
        }

        return result;
    }
}