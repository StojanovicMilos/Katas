using System;
using System.Collections.Generic;

namespace PeriodOfArray
{
    public static class PeriodFinder
    {
        /*
         Problem: Period T of array a. 
         int FindMinimumPeriod(int[] a)
         Number T is a period of array a, if repeating first T elements of array a several times gives you exactly array a, without any extra elements
         */

        public static int FindMinimumPeriod(int[] array)
        {
            foreach (var possiblePeriodLength in GetPossiblePeriodLengths(array.Length))
            {
                if (ArrayHasPeriodLength(array, possiblePeriodLength))
                    return possiblePeriodLength;
            }
            return array.Length;
        }

        private static IEnumerable<int> GetPossiblePeriodLengths(int length)
        {
            for (int i = 1; i <= length / 2; i++)
            {
                if (length % i == 0)
                    yield return i;
            }
        }

        private static bool ArrayHasPeriodLength(int[] array, int possiblePeriodLength)
        {
            int[] periodArray = new int[possiblePeriodLength];
            Array.Copy(array, periodArray, possiblePeriodLength);

            int[] fullArrayWithPeriod = new int[array.Length];
            for (int i = 0; i < array.Length / possiblePeriodLength; i++)
            {
                periodArray.CopyTo(fullArrayWithPeriod, i * possiblePeriodLength);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != fullArrayWithPeriod[i])
                    return false;
            }

            return true;
        }
    }
}
