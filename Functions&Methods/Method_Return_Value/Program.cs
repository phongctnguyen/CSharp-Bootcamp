using System;

namespace Method_Return_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 6);
            Console.WriteLine(result);
            Console.Read();
        }

        public static int Add(int num1, int num2) {
            return num1 + num2;
        }
    }
}
