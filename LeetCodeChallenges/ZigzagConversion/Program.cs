//https://leetcode.com/problems/zigzag-conversion/
using System.Text;

Console.WriteLine("Hello, World!");

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
        {
            return s;
        }

        var rows = new List<StringBuilder>();
        for (var i = 0; i < numRows; i++)
        {
            rows.Add(new StringBuilder());
        }

        var currentRow = 0;
        var goingDown = false;

        foreach (var c in s)
        {
            rows[currentRow].Append(c);
            if (currentRow == 0 || currentRow % (numRows - 1) == 0)
            {
                goingDown = !goingDown;
            }

            currentRow += goingDown ? 1 : -1;
        }

        var result = new StringBuilder();
        foreach (var row in rows)
        {
            result.Append(row);
        }

        return result.ToString();
    }
}