using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AbsoluteDifference(n);
        Console.WriteLine($"Результат: {result}");
    }

    static int AbsoluteDifference(int n)
    {
        int difference = Math.Abs(n - 123);
        if (n > 123)
        {
            return difference * 3;
        }
        return difference;
    }
}
