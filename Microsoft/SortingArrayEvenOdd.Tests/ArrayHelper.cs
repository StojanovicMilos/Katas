namespace SortingArrayEvenOdd.Tests
{
    internal static class ArrayHelper
    {
        internal static bool ArrayIsSorted(int[] array)
        {
            var previous = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (previous % 2 == array[i] % 2)
                {
                    return false;
                }

                previous = array[i];
            }

            return true;
        }
    }
}