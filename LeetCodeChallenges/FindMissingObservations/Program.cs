// https://leetcode.com/problems/find-missing-observations/description/?envType=daily-question&envId=2024-09-05
Console.WriteLine("Hello, World!");

public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int m = rolls.Length;
        int sum = mean * (m + n) - rolls.Sum(x => x);
        if ((sum < n) || (sum > 6 * n))
        {
            return [];
        }

        var result = new List<int>();
        while (sum > 0)
        {
            var averageRoll = sum / n;
            if (n * averageRoll == sum)
            {
                result.AddRange(Enumerable.Repeat(averageRoll, n));
                return result.ToArray();
            }

            sum -= averageRoll;
            n--;
            result.Add(averageRoll);
        }

        return result.ToArray();
    }
}