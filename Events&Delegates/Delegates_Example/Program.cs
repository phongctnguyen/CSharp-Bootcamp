using System;

namespace Delegates_Example
{
  class Program
  {
    public delegate double PerformCalculation(double x, double y);

    public static double Addition(double a, double b)
    {
      Console.WriteLine(a + b);
      return a + b;
    }

    public static double Division(double a, double b)
    {
      Console.WriteLine(a / b);
      return a / b;
    }

    public static double Substraction(double a, double b)
    {
      Console.WriteLine(a - b);
      return a - b;
    }
    static void Main(string[] args)
    {
      PerformCalculation getSum = Addition;
      getSum(2.5, 5.6);

      PerformCalculation getQuotient = Division;
      getQuotient(5.0, 2.4);

      PerformCalculation multiCalc = getSum + getQuotient;
      multiCalc += Substraction;
      multiCalc(3.2, 6.4);
    }
  }
}
