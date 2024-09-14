// https://leetcode.com/problems/minimum-bit-flips-to-convert-number/description
Console.WriteLine("Hello, World!");

public class Solution
{
    public int MinBitFlips(int start, int goal)
    {
        var number = start ^ goal;
        var count = 0;
        while (number > 0)
        {
            count += number & 1;
            number >>= 1;
        }
        return count;
    }
}