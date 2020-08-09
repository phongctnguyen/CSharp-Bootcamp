using System;

namespace Void_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Phong");
            Console.Read();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am callled from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
