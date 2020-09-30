using System;

namespace WordWrap
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }

    /*
    In text editors you can usually find a configuration setting named "Word wrap".
    When checked, lines that do not fit horizontally in the editor window are
    "wrapped" to several lines, thus removing the need for a horizontal scroll
    bar in the window.
    Develop a word-wrapping algorithm, which is given a string and a row-length,
    and returns a String with word-wrapped-rows (using line break `\n`).
    Examples of behaviour:
    If the row-length is 60, and the input string is 30, the result is just the input string
    ("  ", 10) -> "  "
    If the row-length is 3, and the input string is "abc def" the result is "abc", "def"
    ("abc def", 3) -> "abc", "def"
    ("abc def", 4) -> "abc", "def"
    If the row-length is 3, and the input string is "abcdef" the result is "abc", "def"
    If the row-length is 3, and the input string is "abcdef abc" the result is "abc", "def", "abc"
    With row length 3 and "a b c d e f" the result is "a b", "c d", "e f"
    Note: We do not need to trim spaces!
    ("a  c ", 3) -> "a ", "c "
    ("a    ", 3) -> "a ", "  "
    */

    public static class Wrapper
    {
        public static string Wrap(string input, int index)
        {
            if (input.Length < index)
            {
                return input;
            }

            int lastSpaceIndex = input.Substring(0, index+1).LastIndexOf(" ", StringComparison.Ordinal);

            return input.Substring(0, lastSpaceIndex) + Environment.NewLine + input.Substring(lastSpaceIndex + 1);
        }
    }

}
