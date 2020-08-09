using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFriend = "Bum";
            GreatFriend(myFriend);
            Console.Read();
        }

        public static void GreatFriend(string myFriend) {
            Console.WriteLine($"Hi {myFriend}, my friend");
        }
    }
}
