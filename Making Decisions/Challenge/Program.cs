using System;

namespace Challenge
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register() 
        {
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
        }

        public static void Login()
        {
            Console.Write("Enter your username: ");
            if (username == Console.ReadLine()) 
            {
                Console.Write("Enter your password: ");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart Program");
            }
        }
    }
}
