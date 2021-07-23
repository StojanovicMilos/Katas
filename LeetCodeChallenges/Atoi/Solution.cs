using System;
using System.Text;

namespace Atoi
{
    //https://leetcode.com/problems/string-to-integer-atoi
    public class Solution
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();

            if (s.Length == 0)
            {
                return 0;
            }

            var sb = new StringBuilder();
            var i = 0;
            if (s[i] == '-' || s[i] == '+')
            {
                if (s[i] == '-')
                {
                    sb.Append(s[i]);
                }
                i++;
            }

            for (; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    sb.Append(s[i]);
                }
                else
                {
                    break;
                }
            }

            var numbers = sb.ToString();
            if (numbers.Length == 0 || numbers == "-" || numbers == "+")
            {
                return 0;
            }
            int result;
            try
            {
                result = Convert.ToInt32(numbers);
            }
            catch
            {
                result = numbers[0] == '-' ? int.MinValue : int.MaxValue;
            }

            return result;
        }
    }
}
