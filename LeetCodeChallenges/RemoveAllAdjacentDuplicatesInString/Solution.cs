using System.Collections.Generic;
using System.Linq;

namespace RemoveAllAdjacentDuplicatesInString
{
    //https://leetcode.com/explore/challenge/card/june-leetcoding-challenge-2021/606/week-4-june-22nd-june-28th/3794/
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> stack = new Stack<char>(s.Length);
            foreach (var character in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(character);
                }
                else
                {
                    stack.TryPeek(out char element);
                    if (element == character)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(character);
                    }
                }
            }

            return new string(stack.Select(c => c).Reverse().ToArray());
        }
    }
}
