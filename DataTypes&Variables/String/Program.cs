using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Phong";

            string capMyName = myName.ToUpper();

            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"My cap name is {capMyName}");
        }
    }
}
