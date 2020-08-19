using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 0;
            grades[1] = 1;
            grades[2] = 2;
            grades[3] = 3;
            grades[4] = 4;

            Console.WriteLine($"grades at index 0: {grades[0]}");

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine($"grades at index 0: {grades[0]}");
            
            // another way of initializing an array
            int[] gradesOfMathStudentsA = {20, 24, 25, 55, 76};

            // third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] {20, 24, 25, 55, 76};

            Console.WriteLine($"Length of gradesOfMathStudentsA {gradesOfMathStudentsA.Length}");
            Console.ReadKey();
        }
    }
}
