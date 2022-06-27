// https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/submissions/
Console.WriteLine("Hello, World!");

int MinPartitions(string n) => string.IsNullOrEmpty(n) ? 0 : n.ToCharArray().Select(c => int.Parse(c.ToString())).Max();