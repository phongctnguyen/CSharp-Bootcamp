using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch(age) 
            {
                case 15:
                    Console.WriteLine("Too young to party in the club");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you?");
                    break;
            }

            Console.Read();
        }
    }
}
