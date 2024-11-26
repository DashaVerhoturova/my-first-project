using System;

class Program
{
    public static void SortAscending(int[] array)
    {
        Array.Sort(array);
    }

    public static void SortDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
    }

    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        array1.CopyTo(mergedArray, 0);
        array2.CopyTo(mergedArray, array1.Length);
        return mergedArray;
    }

    static void Main()
    {
        int[] array1 = { 5, 2, 9, 1 };
        int[] array2 = { 3, 4, 6 };
        SortAscending(array1);
        Console.WriteLine("Отсортированный массив по возрастанию: " + string.Join(", ", array1));
        SortDescending(array1);
        Console.WriteLine("Отсортированный массив по убыванию: " + string.Join(", ", array1));
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));
    }
}
