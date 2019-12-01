using System;
using System.Linq;

namespace WordCountChallenge
{
    public static class WordsCalculator
    {
        private static readonly char[] Delimiters = {' ', '\r', '\n'};
        public static int CountTotalWords(string text) => text.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

        public static int CountTotalCharacters(string text) => text.Replace(Environment.NewLine, " ").Length;

        public static int CountCharactersWithoutSpaces(string text) => text.Count(t => !char.IsWhiteSpace(t));

        public static MostUsedWord GetMostUsedWord(string text) =>
            text.ToLower()
                .Split(Delimiters, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(word => word)
                .Select(group => new MostUsedWord(word: group.Key, count: group.Count()))
                .OrderByDescending(mostUsedWord => mostUsedWord.Count)
                .FirstOrDefault();

        public static MostUsedChar GetMostUsedChar(string text) =>
            text.ToLower()
                .Where(character => !char.IsWhiteSpace(character))
                .GroupBy(character => character)
                .Select(group => new MostUsedChar(character: group.Key, count: group.Count()))
                .OrderByDescending(g => g.Count)
                .FirstOrDefault();
    }

    public class MostUsedWord
    {
        public string Word { get; }
        public int Count { get; }

        public MostUsedWord(string word, int count)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException(nameof(count));
            Word = word ?? throw new ArgumentNullException(nameof(word));
            Count = count;
        }
    }

    public class MostUsedChar
    {
        public char Char { get; }
        public int Count { get; }

        public MostUsedChar(char character, int count)
        {
            if (character < 0) throw new ArgumentOutOfRangeException(nameof(character));
            if (count <= 0) throw new ArgumentOutOfRangeException(nameof(count));
            Char = character;
            Count = count;
        }
    }
}