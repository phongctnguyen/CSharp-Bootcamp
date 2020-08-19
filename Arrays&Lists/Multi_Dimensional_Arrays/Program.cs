using System;

namespace Multi_Dimensional_Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare 2D Array
      string[,] matrix;

      // 3D Array
      int[,,] threeD;

      // two dimensional array
      int[,] array2D = new int[,]
      {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
      };

      Console.WriteLine($"Central value is {array2D[1, 1]}");

      string[,,] array3D = new string[,,]
      {
          {
              {"000", "001"},
              {"010", "011"}
          },
          {
              {"100", "101"},
              {"110", "111"}
          },
      };

      Console.WriteLine($"The value is {array3D[1, 1, 0]}");

      int dimension = array3D.Rank;
      Console.WriteLine($"The dimension is {dimension}");

      int[,] array2D2 = { { 1, 2 }, { 3, 4 } };
    }
  }
}
