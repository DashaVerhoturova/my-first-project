using System;

class Program
{
    static void Main()
    {
        string str1 = "Когда";
        string str2 = "Будет";
        string str3 = "Стипендия?";
        
        Console.WriteLine("Сравнение с помощью Compare:");
        int result = string.Compare(str1, str2);
        Console.WriteLine($"{result}"); 

        Console.WriteLine("Сравнение с помощью CompareOrdinal:");
        int ordinalResult = string.CompareOrdinal(str1, str2);
        Console.WriteLine($" {ordinalResult}"); 

        Console.WriteLine("Использование Equals:");
        bool areEqual = str1.Equals(str3);
        Console.WriteLine($" {areEqual}");

        Console.WriteLine("Поиск подстроки с помощью IndexOf:");
        int index = str1.IndexOf("д");
        Console.WriteLine($"(\"д\") {index}");

        Console.WriteLine("Проверка на наличие подстроки с помощью Contains:");
        bool contains = str3.Contains("Стип");
        Console.WriteLine($"(\"Стип\") {contains}");

        Console.WriteLine("Использование операторов == и !=:");
        Console.WriteLine($" {str1 == str3}");
        Console.WriteLine($" {str1 != str2}"); 

    }
}
