using System;

namespace Foreach_Loop
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = new int[10];

      for (int i = 0; i < nums.Length; i++)
      {
          nums[i] = i;
      }

      foreach (int num in nums)
      {
          Console.WriteLine(num);
      }
    }
  }
}
