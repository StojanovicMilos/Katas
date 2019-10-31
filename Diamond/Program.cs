using System;
using System.Collections.Generic;
using System.Linq;

namespace Diamond
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Diamond.Create(25));
        }
    }

    public static class Diamond
    {
        private const char Asterisk = '*';

        public static string Create(int diamondSize) =>
            Enumerable.Range(0, diamondSize)
                .Select(rowIndex => CreateRow(rowIndex, diamondSize))
                .Join(Environment.NewLine);

        private static string CreateRow(int rowIndex, int diamondSize)
        {
            char[] row = new string(' ', diamondSize).ToCharArray();

            int middleIndex = GetMiddleIndex(diamondSize);
            int charIndex = GetCharIndex(rowIndex, diamondSize);
            
            row[middleIndex - charIndex] = Asterisk;
            row[middleIndex + charIndex] = Asterisk;

            return new string(row);
        }

        private static int GetMiddleIndex(int diamondSize) => (diamondSize - 1) / 2;

        private static int GetCharIndex(int rowIndex, int diamondSize) =>
            rowIndex <= GetMiddleIndex(diamondSize)
                ? rowIndex
                : diamondSize - 1 - rowIndex;
    }

    public static class StringExtensions
    {
        public static string Join(this IEnumerable<string> sequence, string separator) =>
            string.Join(separator, sequence);
    }
}
