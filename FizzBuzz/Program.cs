using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main()
        {
            RunFizzBuzz();
            Console.ReadLine();
        }

        private static void RunFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
        }

        public static string FizzBuzz(int i)
        {
            string output = string.Empty;
            if (i % 3 == 0)
            {
                output += "Fizz";
            }

            if (i % 5 == 0)
            {
                output += "Buzz";
            }

            if (output == string.Empty)
            {
                output = i.ToString();
            }

            return output;
        }
    }
}
