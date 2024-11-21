using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Пожалуйста, введите корректное целое число.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Завершение выполнения программы.");
        }
    }
}
