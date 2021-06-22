using System.Collections.Generic;
using System.Linq;

namespace NumberOfMatchingSubsequences
{
    //https://leetcode.com/explore/challenge/card/june-leetcoding-challenge-2021/606/week-4-june-22nd-june-28th/3788/
    public class Solution
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                    continue;
                }
                if (word.Any(character => !s.Contains(character)))
                {
                    continue;
                }

                var wordIndex = 0;

                for (var index = 0; index < s.Length; index++)
                {
                    var character = s[index];
                    if (character != word[wordIndex])
                    {
                        continue;
                    }

                    wordIndex++;
                    if (wordIndex == word.Length)
                    {
                        dictionary[word] = 1;
                        break;
                    }
                }
            }

            return dictionary.Sum(keyValuePair => keyValuePair.Value);
        }
    }
}
