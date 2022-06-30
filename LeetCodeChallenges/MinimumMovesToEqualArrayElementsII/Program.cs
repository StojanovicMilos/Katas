// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii
Console.WriteLine(MinMoves2(new[] { 1, 0, 0, 8, 6 }));

int MinMoves2(int[] nums)
{
    var median = Median(nums);
    var sum = 0;
    foreach (var number in nums)
    {
        sum += Math.Abs(number - median);
    }
    return sum;
}

int Median(int[] numbers)
{
    var ys = numbers.OrderBy(x => x).ToList();
    double mid = (ys.Count - 1) / 2.0;
    return (ys[(int)(mid)] + ys[(int)(mid + 0.5)]) / 2;
}