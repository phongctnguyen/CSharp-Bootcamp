using System;

namespace Math_Class
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Ceiling: {Math.Ceiling(15.3)}"); // 16
      Console.WriteLine($"Floor: {Math.Floor(15.3)}"); // 15

      int num1 = 13;
      int num2 = 9;
      Console.WriteLine($"Lower of num1 {num1} and num2 {num2} is {Math.Min(num1, num2)}"); // 9
      Console.WriteLine($"Higher of num1 {num1} and num2 {num2} is {Math.Max(num1, num2)}"); // 13

      Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}"); // 243

      Console.WriteLine($"PI is {Math.PI}"); // 3.141592653589793

      Console.WriteLine($"Square root of 25 is {Math.Sqrt(25)}"); // 5

      Console.WriteLine($"Always positive is {Math.Abs(-25)}"); // 25
    }
  }
}
