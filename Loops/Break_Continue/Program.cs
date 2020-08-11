using System;

namespace Break_Continue
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int counter = 0; counter < 10; counter++)
      {
        if (counter == 3)
        {
          //   Console.WriteLine($"At {counter} we stop");
          //   break;
          Console.WriteLine($"At {counter} we stop");
          continue;
        }
        Console.WriteLine(counter);
      }
      Console.Read();
    }
  }
}
