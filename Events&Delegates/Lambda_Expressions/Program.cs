using System;

namespace Lambda_Expressions
{
  class Program
  {
    public delegate string GetTextDelegate(string name);

    public delegate double GetResultDelegate(double a, double b);

    static void Main(string[] args)
    {
      GetTextDelegate getTextDelegate = delegate (string name)
      {
        return "Hello, " + name;
      };

      // Expression Lambda 
      GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };

      // Statement Lambda
      GetTextDelegate getGoodbyeText = (string name) =>
      {
        Console.WriteLine("I am inside of an statement lambda");
        return "Goodbye, " + name;
      };

      GetTextDelegate getWelcomeText = name => "Welcome, " + name;

      GetResultDelegate getSum = (a, b) => a + b;

      GetResultDelegate getProduct = (a, b) => a * b; 
      
      Console.WriteLine(getHelloText("Phong"));
      Display(getTextDelegate);
      DisplayNum(getSum);
      DisplayNum(getProduct);
    }

    static void DisplayNum(GetResultDelegate getResultDelegate)
    {
      Console.WriteLine(getResultDelegate(1, 2));
    }

    static void Display(GetTextDelegate getTextDelegate)
    {
      Console.WriteLine(getTextDelegate("World"));
    }
  }
}
