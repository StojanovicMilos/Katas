using System;
using System.Linq;

namespace SortingArrayEvenOdd
{
    //U linearnom vremenu bez dodatne memorije sortirati niz tako da nema dva parna ili dva neparna broja jedan pored drugog
    //without using additional memory, in linear time (O(n)) sort given array so that no two even or no two odd numbers are next to each other
    public static class Sorter
    {
        public static void Sort(int[] array)
        {
            var numberOfOdds = array.Count(num => num % 2 == 1);
            var numberOfEvens = array.Count(num => num % 2 == 0);
            if (Math.Abs(numberOfEvens - numberOfOdds) > 1)
            {
                throw new ArgumentException($"array [{string.Join(", ", array.Select(num => num))}] is not sortable.");
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                var previous = array[i - 1];
                var current = array[i];
                var next = array[i + 1];

                //everything all right, moving on
                if (current.IsDifferentParityThan(next) && current.IsDifferentParityThan(previous))
                {
                    continue;
                }

                //need to change current
                if (previous.IsSameParityAs(next))
                {
                    //handle
                    continue;
                }

                if (previous.IsSameParityAs(current))
                {
                    array[i] = next;
                    array[i + 1] = current;
                }
            }
        }
    }

    public static class IntExtensions
    {
        public static bool IsEven(this int number) => number % 2 == 0;
        public static bool IsOdd(this int number) => !number.IsEven();
        public static int ModTwo(this int number) => number % 2;
        public static bool IsSameParityAs(this int number, int other) => number.ModTwo() == other.ModTwo();
        public static bool IsDifferentParityThan(this int number, int other) => !number.IsSameParityAs(other);
    }
}
