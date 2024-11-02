// https://leetcode.com/problems/top-k-frequent-elements/description/
Console.WriteLine("Hello, World!");

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return nums.GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .Take(k)
                .Select(g => g.Key)
                .ToArray();
    }
}