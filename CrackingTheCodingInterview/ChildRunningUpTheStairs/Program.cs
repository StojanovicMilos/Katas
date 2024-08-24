// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Child.RunUpStaircase(10));

static class Child
{
    static readonly int[] steps = [1, 2, 3];
    internal static int RunUpStaircase(int remainingSteps)
        => remainingSteps == 0
            ? 1
            : steps.Where(step => step <= remainingSteps)
                    .Sum(step => RunUpStaircase(remainingSteps - step));
}