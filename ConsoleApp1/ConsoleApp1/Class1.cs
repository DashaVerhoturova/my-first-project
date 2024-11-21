namespace MyLibrary
{
    public class MyClass
    {
      
        public void MethodVoid()
        {
            Console.WriteLine("Этот метод ничего не возвращает.");
        }

     
        public int MethodReturnInt()
        {
            return 42;
        }

     
        public string MethodReturnString()
        {
            return "Привет из DLL!";
        }

      
        public double MethodReturnDouble()
        {
            return 3.14;
        }
    }

}
