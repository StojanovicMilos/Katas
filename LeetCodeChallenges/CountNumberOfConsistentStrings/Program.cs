//https://leetcode.com/problems/count-the-number-of-consistent-strings/description/
Console.WriteLine("Hello, World!");

Console.WriteLine(Solution.CountConsistentStrings("abc", ["a", "b", "c", "ab", "ac", "bc", "abc"]));

public static class Solution
{
    public static int CountConsistentStrings(string allowed, string[] words)
    {
        var allowedSet = new HashSet<char>(allowed);
        return words.Count(w => w.All(c => allowedSet.Contains(c)));
    }
}