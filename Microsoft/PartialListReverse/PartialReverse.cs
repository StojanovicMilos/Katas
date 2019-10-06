using System;
using System.Collections.Generic;
using System.Linq;

namespace PartialListReverse
{
    public static class PartialReverse
    {
        public static List<T> ReverseNodes<T>(List<T> list, int startIndex, int endIndex)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));

            T[] array = list.ToArray();

            if (startIndex <= 0) throw new ArgumentOutOfRangeException(nameof(startIndex));
            if (endIndex > array.Length) throw new ArgumentOutOfRangeException(nameof(endIndex));
            if (endIndex < startIndex) throw new ArgumentException(nameof(startIndex) + " must be before " + nameof(endIndex));

            if (startIndex == endIndex)
                return list;

            startIndex--; //start index 1 means first element, this way I can index array[startIndex]
            endIndex--;
            for (int i = 0; i < (endIndex - startIndex) / 2 + 1; i++)
            {
                int firstElement = startIndex + i;
                int secondElement = endIndex - i;
                T temp = array[firstElement];
                array[firstElement] = array[secondElement];
                array[secondElement] = temp;
            }

            return array.ToList();
        }
    }
}
