// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        if (sentence == null)
        {
            return false;
        }

        if (sentence.Length <= 1)
        {
            return true;
        }

        if (sentence[0] != sentence[sentence.Length - 1])
        {
            return false;
        }

        for (var i = 1; i < sentence.Length - 1; i++)
        {
            if ((sentence[i] == ' ') && (sentence[i - 1] != sentence[i + 1]))
            {
                return false;
            }
        }

        return true;
    }
}