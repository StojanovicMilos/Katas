// https://leetcode.com/problems/search-insert-position/
Console.WriteLine("Hello, World!");
Console.WriteLine(SearchInsert(new int[] { 1, 3 }, 2));

int SearchInsert(int[] nums, int target)
{
    if (target < nums[0])
    {
        return 0;
    }
    if (target > nums[nums.Length - 1])
    {
        return nums.Length;
    }
    int bottom = 0;
    int top = nums.Length - 1;
    int half = 0;
    while (top >= bottom)
    {
        half = (top + bottom) / 2;
        if (nums[half] == target)
        {
            return half;
        }
        else if (nums[half] > target)
        {
            top = half - 1;
        }
        else
        {
            bottom = half + 1;
        }
    }

    return bottom;
}