// https://leetcode.com/problems/ugly-number-ii/description/
Console.WriteLine(NthUglyNumber(1609));

int NthUglyNumber(int n)
{
    long[] factors = [2, 3, 5];
    var queue = new PriorityQueue<long, long>();
    var visited = new HashSet<long>();

    queue.Enqueue(1, 1);
    for (var i = 0; i < n-1; i++)
    {
        var ugly = queue.Dequeue();
        foreach (var factor in factors)
        {
            var newUgly = ugly * factor;
            if (!visited.Contains(newUgly))
            {
                queue.Enqueue(newUgly, newUgly);
                visited.Add(newUgly);
            }
        }
    }

    return (int)queue.Dequeue(); //nice job leetcode, return value has to be int...
}