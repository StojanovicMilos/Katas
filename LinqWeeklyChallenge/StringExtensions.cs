using System.Collections.Generic;
using System.Linq;

namespace LinqWeeklyChallenge
{
    public static class StringExtensions
    {
        public static IEnumerable<ReturnObject> ConvertToObjectList(this string s)
        {
            return s.ToLower()
                .GroupBy(c => c)
                .Select(o => new ReturnObject {Char = o.Key, Count = o.Count()})
                .OrderByDescending(o => o.Count)
                .ThenBy(o => o.Char);
        }
    }

    public class ReturnObject
    {
        public char Char { get; set; }
        public int Count { get; set; }
    }
}
