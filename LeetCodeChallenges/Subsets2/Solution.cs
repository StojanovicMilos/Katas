using System.Collections.Generic;
using System.Linq;

namespace Subsets2
{
    //https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/613/week-1-august-1st-august-7th/3837/
    public class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var result = new List<IList<int>> { new List<int>() };
            foreach (var num in nums.OrderBy(n=>n))
            {
                var newSubsets = new List<IList<int>>();
                foreach (var newSubset in result.Select(oldSubset => oldSubset.ToList()))
                {
                    newSubset.Add(num);
                    newSubsets.Add(newSubset);
                }

                foreach (var newSubset in newSubsets.Where(newSubset => result.All(list => !list.SequenceEqual(newSubset))))
                {
                    result.Add(newSubset);
                }
            }

            return result;
        }
    }
}
