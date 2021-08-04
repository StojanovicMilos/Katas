using System;
using System.Linq;

namespace LongestCommonPrefix
{
    //https://leetcode.com/problems/longest-common-prefix
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null)
            {
                throw new ArgumentNullException(nameof(strs));
            }

            if (strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var upper = strs.WithMinimum(s => s.Length).Length;
            var current = upper / 2;
            var lower = 0;

            while (upper > lower + 1)
            {
                var value = strs[0].Substring(0, current);
                if (strs.All(s => s.Substring(0, current) == value))
                {
                    lower = current;
                }
                else
                {
                    upper = current;
                }

                current = (upper + lower) / 2;
            }

            if (upper == lower + 1)
            {
                var value = strs[0].Substring(0, upper);
                current = strs.All(s => s.Substring(0, upper) == value) ? upper : lower;
            }

            return strs[0].Substring(0, current);
        }
    }
}