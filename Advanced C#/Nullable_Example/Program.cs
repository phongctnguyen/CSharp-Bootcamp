using System;

namespace Nullable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14;

            bool? boolVal = new bool?();

            Console.WriteLine($"Our nullable values are {num1}, {num2}, {num3}, {num4}, {boolVal}");

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num5 = 13.1;
            double? num6 = null;
            double? num7;

            if (num5 == null)
            {
                num7 = 0.0;
            }
            else
            {
                num7 = (double)num5;
            }

            Console.WriteLine($"Value of num7 is {num7}");

            // The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result. The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.

            num7 = num5 ?? 8.53;
            Console.WriteLine($"Value of num7 is {num7}");

            num7 =num6 ?? 8.53;
            Console.WriteLine($"Value of num7 is {num7}");
        }
    }
}
