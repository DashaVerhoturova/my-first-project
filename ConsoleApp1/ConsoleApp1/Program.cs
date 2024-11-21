using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();

        myClass.MethodVoid();
        Console.WriteLine(myClass.MethodReturnInt());
        Console.WriteLine(myClass.MethodReturnString());
        Console.WriteLine(myClass.MethodReturnDouble());

        Console.ReadLine();
    }
}
