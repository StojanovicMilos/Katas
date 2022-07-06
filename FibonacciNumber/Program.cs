// https://leetcode.com/problems/fibonacci-number/
Console.WriteLine("Hello, World!");

int Fib(int n)
{
    if (n == 0 || n == 1) return n;
    var prev = 0;
    var curr = 1;
    var next = 1;
    for (int i = 2; i < n + 1; i++)
    {
        next = prev + curr;
        prev = curr;
        curr = next;
    }
    return next;
}