using System.Collections.Generic;

namespace IsomorphicStrings
{
    public static class IsomorphicStringsChecker
    {
        /*
         Two strings A and B are isomorphic if there exists character mapping which maps characters from A to get B. Rules for character mapping are:
             - all occurrences of one character must be replaced with the same character
             - no two different characters may map to the same character
             - a character may map to itself
         
          Write a function that returns true if provided strings are isomorphic, otherwise false
         */

        public static bool AreStringsIsomorphic(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            Dictionary<char, char> mapping = new Dictionary<char, char>();

            for (int i = 0; i < a.Length; i++)
            {
                char key = a[i];
                char value = b[i];

                if (mapping.ContainsKey(key))
                {
                    mapping.TryGetValue(key, out var existingValue);
                    if (existingValue != value)
                    {
                        return false;
                    }
                }
                else
                {
                    mapping.Add(key, value);
                }
            }

            return true;
        }
    }
}
