using System;

namespace Nested_If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin =  false;
            bool isRegistered = true;
            string userName = "";
            Console.Write("Enter your username: ");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, admin");
                    }
                }
            }

            Console.Read();
        }
    }
}
