// https://leetcode.com/problems/wiggle-subsequence/
Console.WriteLine("Hello, World!");
Console.WriteLine(WiggleMaxLength(new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 }));

int WiggleMaxLength(int[] nums)
{
    if (nums.Length < 2)
    {
        return nums.Length;
    }
    int prevdiff = nums[1] - nums[0];
    int count = prevdiff != 0 ? 2 : 1;
    for (int i = 2; i < nums.Length; i++)
    {
        int diff = nums[i] - nums[i - 1];
        if ((diff > 0 && prevdiff <= 0) || (diff < 0 && prevdiff >= 0))
        {
            count++;
            prevdiff = diff;
        }
    }
    return count;
}