using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string myString = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            char myChar = Console.ReadLine()[0];

            Console.WriteLine(myString.IndexOf(myChar));

            Console.Write("Enter your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine(String.Concat(myFirstName, " ", myLastName));

        }
    }
}
