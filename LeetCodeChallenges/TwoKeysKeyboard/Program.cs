//https://leetcode.com/problems/2-keys-keyboard/description/?envType=daily-question&envId=2024-08-21
Console.WriteLine("Hello, World!");
Console.WriteLine(MinSteps(9));

int MinSteps(int n)
{
    var factors = GetPrimeFactors(n);
    return factors.Sum();
}

static List<int> GetPrimeFactors(int n)
{
    var factors = new List<int>();
    while (n % 2 == 0)
    {
        factors.Add(2);
        n /= 2;
    }

    for (int i = 3; i <= Math.Sqrt(n); i += 2)
    {
        while (n % i == 0)
        {
            factors.Add(i);
            n /= i;
        }
    }

    if (n > 1)
    {
        factors.Add(n);
    }

    return factors;
}