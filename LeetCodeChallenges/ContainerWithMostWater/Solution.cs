// See https://aka.ms/new-console-template for more information
//https://leetcode.com/problems/container-with-most-water/description/

public class Solution
{
    public static int MaxAreaBruteForce(int[] height)
    {
        var max = 0;
        for (var i = 0; i < height.Length - 1; i++)
        {
            for (var j = 1; j < height.Length; j++)
            {
                var current = (j - i) * Math.Min(height[i], height[j]);
                if(current > max)
                {
                    max = current;
                }
            }
        }
        return max;
    }

    public static int MaxArea(int[] height)
    {
        var max = 0;
        var left = 0;
        var right = height.Length - 1;
        while (left < right)
        {
            var current = (right - left) * Math.Min(height[left], height[right]);
            if (current > max)
            {
                max = current;
            }
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return max;
    }
}