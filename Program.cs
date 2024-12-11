using System;

internal class Program
{
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }

    static void Fill(int[] arr, int min = 0, int max = 50)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }

    static void PushBack(ref int[] arr, int value)
    {
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = value;
    }

    private static void Main(string[] args)
    {
        int[] arr = new int[10];
        Fill(arr, 1, 100);
        Print(arr, "Print Random Array :: ");

        int evenCount = 0;
        int oddCount = 0;
        foreach (var item in arr)
        {
            if (item % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }
        Console.WriteLine($"Number of even elements: {evenCount}");
        Console.WriteLine($"Number of odd elements: {oddCount}");

        int uniqueCount = 0;
        int[] uniqueArray = new int[arr.Length];
        int uniqueIndex = 0;

        foreach (var item in arr)
        {
            if (Array.IndexOf(uniqueArray, item) == -1)
            {
                uniqueArray[uniqueIndex++] = item;
                uniqueCount++;
            }
        }

        Console.WriteLine($"Number of unique elements: {uniqueCount}");

        int[] uniqueElements = new int[uniqueCount];
        Array.Copy(uniqueArray, uniqueElements, uniqueCount);
        Print(uniqueElements, "Unique Elements :: ");
    }
}
