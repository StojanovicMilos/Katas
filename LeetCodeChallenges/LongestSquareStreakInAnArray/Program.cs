//https://leetcode.com/problems/longest-square-streak-in-an-array/?envType=daily-question&envId=2024-10-28
Console.WriteLine(LongestSquareStreak([4, 16, 256, 65536]));

int LongestSquareStreak(int[] nums)
{
    var hash = new HashSet<int>(nums);
    var sortedNums = nums.OrderBy(x => x);
    var maxLength = 0;

    foreach (var num in sortedNums)
    {
        var length = 0;
        var current = num;

        while (hash.Contains(current))
        {
            length++;
            if(current > Math.Sqrt(int.MaxValue))
            {
                break;
            }

            current *= current;
        }

        if (length > 1)
        {
            maxLength = Math.Max(maxLength, length);
        }
    }

    return maxLength > 1 ? maxLength : -1;
}