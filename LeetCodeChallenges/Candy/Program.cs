// https://leetcode.com/problems/candy
Console.WriteLine("Hello, World!");

int Candy(int[] ratings)
{
    int[] res = Enumerable.Repeat<int>(1, ratings.Length).ToArray();

    for (int i = 1; i < ratings.Length; i++)
    {
        if (ratings[i] > ratings[i - 1])
        {
            res[i] = res[i - 1] + 1;
        }
    }

    for (int i = ratings.Length - 2; i >= 0; i--)
    {
        if (ratings[i] > ratings[i + 1])
        {
            res[i] = Math.Max(res[i], res[i + 1] + 1);
        }
    }

    return res.Sum();
}