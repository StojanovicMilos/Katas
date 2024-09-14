// https://leetcode.com/problems/xor-queries-of-a-subarray/description/
Console.WriteLine("Hello, World!");

public class Solution
{
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        var result = new List<int>();
        foreach (var query in queries)
        {
            var xorResult = 0;
            for (var i = query[0]; i <= query[1]; i++)
            {
                xorResult ^= arr[i];
            }

            result.Add(xorResult);
        }

        return result.ToArray();
    }
}