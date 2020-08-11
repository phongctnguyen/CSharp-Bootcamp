using System;

namespace For_Loop
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int counter = 0; counter < 10; counter++)
      {
        Console.WriteLine(counter);
      }

      for (int counter = 0; counter < 10; counter += 2)
      {
        Console.WriteLine(counter);
      }
      Console.Read();
    }
  }
}
