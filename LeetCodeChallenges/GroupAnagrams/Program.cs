using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    //https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/614/week-2-august-8th-august-14th/3887/
    public static class Program
    {
        public static void Main()
        {
            var strs = new[] {"eat", "tea", "tan", "ate", "nat", "bat"};

            IList<IList<string>> result = strs
                .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
                .Select(group =>
                {
                    IList<string> list = group.Select(g => g).ToList();
                    return list;
                })
                .ToList();

            foreach (var enumerable in result)
            {
                Console.WriteLine(string.Join(", ", enumerable));
            }
        }
    }
}
