using System.Linq;

namespace nonNegativeIntegersWithoutConsecutiveOnes
{
    //https://leetcode.com/explore/challenge/card/july-leetcoding-challenge-2021/611/week-4-july-22nd-july-28th/3826/
    public class Solution
    {
        public int FindIntegersV1(int n) =>
            Enumerable
                .Range(0, n + 1)
                .Count(value =>
                {
                    var previous = 0;
                    while (value > 0)
                    {
                        var remainder = value % 2;
                        if (remainder == 1 && previous == 1)
                        {
                            return false;
                        }

                        previous = remainder;
                        value /= 2;
                    }

                    return true;
                });

        public int FindIntegersV2(int n)
        {
            var count = 0;
            for (int i = 0; i <= n; i++)
            {
                if (HasNoConsecutiveOnes(n))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool HasNoConsecutiveOnes(in int value)
        {
            int i = 31;
            while (i > 0)
            {
                if ((value & (1 << i)) != 0 && (value & (1 << (i - 1))) != 0)
                    return false;
                i--;
            }

            return true;
        }
    }
}
