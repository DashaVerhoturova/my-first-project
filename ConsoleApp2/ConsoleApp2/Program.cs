using System.Threading.Channels;

public class Sum
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    private int minus(int c, int d)
    {
        return c - d;
    }
    public int Pminus(int z, int q)
    {
        return minus(z, q);
    }
}

public class User
{
   
    public int Id { get; set; } 
    public string Name { get; set; }  // Имя пользователя
    public string SecondName { get; set; }  // Фамилия пользователя
    public string Mail { get; set; }  // Электронная почта
    public string Password { get; set; }  // Пароль пользователя
    public string NumberFone { get; set; }  // Номер телефона (если есть)
}
class Program { 
    static void Main(string[] args)
    {
        Sum sum = new Sum();
        int a = 10; int b = 20;
        Console.WriteLine(sum.Add(a, b));
        Console.WriteLine(sum.Pminus(a, b));
        User user = new User();
        user.Id = 157;
        user.Name = "Иван";
        user.SecondName = "Иванов";
        user.Mail = "IvanovIvanIvanovich@gmail.com";
        user.Password = "00000000";
        user.NumberFone = "79140001122";

        Console.WriteLine($"ID: {user.Id}");
        Console.WriteLine($"имя: {user.Name}");
        Console.WriteLine($"Фамилия: {user.Password}");
        Console.WriteLine($"Почта: {user.Mail}");
        Console.WriteLine($"Пароль: {user.Password}");
        Console.WriteLine($"Телефон: {user.NumberFone}");
    }
    
}