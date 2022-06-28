// https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique
Console.WriteLine("Hello, World!");
Console.WriteLine(MinDeletions("ceabaacb"));

int MinDeletions(string s)
{
    var numbers = s.ToCharArray()
            .GroupBy(x => x)
            .Select(group => group.Count()
            )
            .OrderByDescending(x => x);

    var result = 0;
    HashSet<int> hashSet = new HashSet<int>();

    foreach (var number in numbers)
    {
        var changeableNumber = number;
        if (!hashSet.Contains(changeableNumber))
        {
            hashSet.Add(changeableNumber);
        }
        else
        {
            while(hashSet.Contains(changeableNumber))
            {
                result++;
                changeableNumber--;
            }
            if(changeableNumber > 0)
            {
                hashSet.Add(changeableNumber);
            }
        }
    }

    return result;
}