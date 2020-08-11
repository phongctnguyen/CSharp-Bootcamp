using System;

namespace While_Loop
{
  class Program
  {
    static void Main(string[] args)
    {
      int counter = 0;
      while (counter < 10)
      {
          Console.WriteLine(counter);
          counter++;
      }
      Console.Read();
    }
  }
}
