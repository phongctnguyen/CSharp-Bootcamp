using System;

namespace Try_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your temperature today: ");
            string tempInput = Console.ReadLine();
            int temp;
            int number;

            if (int.TryParse(tempInput, out number)) 
            {
                temp = number;
            }
            else 
            {
                temp = 0;
                Console.WriteLine("Wrong input");
            }

            if (temp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temp == 20) 
            {
                Console.WriteLine("Pants and Pull Over shoulld be fine");
            }
            else 
            {
                Console.WriteLine("Shorts are enough today");
            }
        }
    }
}
