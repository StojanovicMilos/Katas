namespace RelativeRanks
{
    //https://leetcode.com/problems/relative-ranks/description/?envType=daily-question&envId=2024-05-08
    public static class Solution
    {
        public static string[] FindRelativeRanks(int[] score)
        {
            return score
                .Select((value, index) => new
                {
                    Index = index,
                    Value = value
                })
                .OrderByDescending(x => x.Value)
                .Select((value, index) => new
                {
                    Index = value.Index,
                    Value = Map(index)
                })
                .OrderBy(x => x.Index)
                .Select(x => x.Value)
                .ToArray();
        }

        private static string Map(int index)
        => index switch
        {
            0 => "Gold Medal",
            1 => "Silver Medal",
            2 => "Bronze Medal",
            _ => (index+1).ToString()
        };
    }
}
