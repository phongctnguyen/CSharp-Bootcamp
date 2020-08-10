using System;

namespace Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      int counter = 0;
      int num = 0;
      int sum = 0;
      string numInput;
      int numOutput;

      while (true)
      {
        Console.Write("Enter the number: ");
        numInput = Console.ReadLine();
        if (int.TryParse(numInput, out numOutput))
        {
          num = numOutput;

          if (num == -1)
          {
            break;
          }

          if ((num < 0 || num > 20) && num != -1)
          {
            Console.WriteLine("Please enter a number in range 0 -> 20");
            continue;
          }

          sum += num;
          counter++;
        }

        else
        {
          Console.WriteLine("Wrong output");
          continue;
        }
      }

      double average = 0;

      if (counter == 0) average = 0;
      average = (double)sum / (double)counter;

      Console.WriteLine($"Average is {average}");
    }
  }
}
