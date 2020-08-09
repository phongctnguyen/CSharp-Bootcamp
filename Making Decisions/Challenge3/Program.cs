using System;

namespace Challenge3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter your temp: ");
      string tempInput = Console.ReadLine();

      int temp = 0, tempOutput;
      string stateOfMatter;

      if (int.TryParse(tempInput, out tempOutput))
      {
        temp = tempOutput;

        stateOfMatter = temp <= 15 ? "it is too cold here" : (temp >= 16 && temp <= 28) ? "it is ok" : "it is hot here";
        Console.WriteLine(stateOfMatter);
      }
      else
      {
        Console.WriteLine("Not a valid Temperature");
      }
    }
  }
}
