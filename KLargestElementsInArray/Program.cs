// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(PrintArray(KLargestElementsIn(new[] { 1, 23, 12, 9, 30, 2, 50 }, 5)));

int[] KLargestElementsIn(int[] array, int k)
{
    if (k > array.Length)
    {
        throw new InvalidOperationException();
    }

    if (k == array.Length)
    {
        return array;
    }

    //if k < n/2 use selection sort n-k times and then skip smallest n-k elements to get k largest ones

    //else use bubble sort k times
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                var temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    return array.Skip(array.Length - k).Take(k).ToArray();
}

string PrintArray(int[] array) => string.Join(", ", array);