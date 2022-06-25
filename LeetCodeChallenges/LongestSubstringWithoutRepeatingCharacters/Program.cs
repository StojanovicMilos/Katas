// https://leetcode.com/problems/longest-substring-without-repeating-characters
Console.WriteLine("Hello, World!");
var solution = LengthOfLongestSubstring("umvejcuka");
Console.WriteLine(solution);

int LengthOfLongestSubstring(string s)
{
    if(s == null)
    {
        return 0;
    }

    var unique = new List<char>();
    int max = 0;
    for (int right = 0; right < s.Length; right++)
    {
        if (!unique.Contains(s[right]))
        {
            unique.Add(s[right]);
            max = Math.Max(unique.Count, max);
        }
        else
        {
            unique.RemoveRange(0, Convert.ToInt32(unique.IndexOf(s[right])) + 1);
            unique.Add(s[right]);
        }
    }
    return max;
}