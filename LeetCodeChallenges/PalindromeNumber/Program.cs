// https://leetcode.com/problems/palindrome-number
Console.WriteLine(IsPalindrome(55155));

bool IsPalindrome(int x) {
    if (x < 0)
    {
        return false;
    }

    if (x < 10)
    {
        return true;
    }

    string s = x.ToString();

    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}