using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = - num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny {!isSunny}");

            // increment operator
            int num = 0;
            num++;
            Console.WriteLine($"num is {num}");

            // decrement operator
            num--;
            Console.WriteLine($"num is {num}");

            // + - * /

            // relational and type operators (<, >, ==, !=)
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine(isLower);

            // conditional operators (&&,, ||)
        }
    }
}
