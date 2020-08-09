using System;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your temperature today: ");
            string tempInput = Console.ReadLine();
            int temp = int.Parse(tempInput);

            if (temp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temp == 20)
            {   
                Console.WriteLine("It is 10 degrees C");
            }
            else 
            {
                Console.WriteLine("Cozy warm");
            }
        }
    }
}
