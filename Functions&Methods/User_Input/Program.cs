using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate() {
            Console.WriteLine("Enter your first number: ");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter your second number: ");
            string secondInput = Console.ReadLine();

            int firstNum = int.Parse(firstInput);
            int secondNum = int.Parse(secondInput);

            return firstNum + secondNum;
        }
    }
}
