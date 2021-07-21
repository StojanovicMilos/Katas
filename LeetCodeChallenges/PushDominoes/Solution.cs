using System;
using System.Linq;

namespace PushDominoes
{
    //https://leetcode.com/explore/challenge/card/july-leetcoding-challenge-2021/610/week-3-july-15th-july-21st/3821/
    public class Solution
    {
        public string PushDominoes(string dominoes)
        {
            var forces = new int[dominoes.Length];

            var forceToRight = 0;
            for (int i = 0; i < dominoes.Length; ++i)
            {
                forceToRight = dominoes[i] switch
                {
                    'R' => dominoes.Length,
                    'L' => 0,
                    _ => Math.Max(forceToRight - 1, 0)
                };

                forces[i] += forceToRight;
            }

            var forceToLeft = 0;
            for (int i = dominoes.Length - 1; i >= 0; --i)
            {
                forceToLeft = dominoes[i] switch
                {
                    'L' => dominoes.Length,
                    'R' => 0,
                    _ => Math.Max(forceToLeft - 1, 0)
                };

                forces[i] -= forceToLeft;
            }

            return new string(forces.Select(f => f > 0 ? 'R' : f < 0 ? 'L' : '.').ToArray());
        }
    }
}
