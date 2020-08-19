﻿using System;

namespace Jagged_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare jaggedArray
      int[][] jaggedArray = new int[3][];

      jaggedArray[0] = new int[5];
      jaggedArray[1] = new int[3];
      jaggedArray[2] = new int[2];

      jaggedArray[0] = new int[] { 2, 4, 5, 7, 11 };
      jaggedArray[1] = new int[] { 1, 2, 3 };
      jaggedArray[2] = new int[] { 13, 21 };

      // alternative way
      int[][] jaggedArray2 = new int[][]
      {
                new int[] {2, 4, 5, 7, 11},
                new int[] {1, 2, 3}
      }; 

      Console.WriteLine($"The value in the middle of the first entry is {jaggedArray2[0][2]}");

      for (int i = 0; i < jaggedArray2.Length; i++) {
          Console.WriteLine($"Element {i}");

          for (int j = 0; j < jaggedArray2[i].Length; j++) {
              Console.WriteLine($"{jaggedArray2[i][j]}");
          }
      }
    }
  }
}
