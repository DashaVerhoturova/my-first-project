using System;
using System.Globalization;
class Program
{
    static void Main()
    {
 
        string num = "12345";
        string num2 = "12,345";

      
        int number = Int32.Parse(num);
        Console.WriteLine($"Метод Parse: {number}");

  
        if (Int32.TryParse(num2, out int result))
        {
            Console.WriteLine($"Метод TryParse: {result}");
        }
        else
        {
            Console.WriteLine("Не удалось распознать число");
        }

        string dateString = "2023-10-31";
        string invalidDateString = "31/10/2023";

  
        DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        Console.WriteLine($"Метод ParseExact: {date}");

     
        if (DateTime.TryParseExact(invalidDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime invalidDate))
        {
            Console.WriteLine($"Метод TryParseExact: {invalidDate}");
        }
        else
        {
            Console.WriteLine("Ну удалось распознать число");
        }
    }
}