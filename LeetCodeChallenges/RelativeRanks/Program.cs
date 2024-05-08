// See https://aka.ms/new-console-template for more information
using RelativeRanks;

Console.WriteLine("Hello, World!");

int[] score = [5, 4, 3, 2, 1];
var solution = Solution.FindRelativeRanks(score);
foreach (var rank in solution)
{
    Console.WriteLine(rank);
}