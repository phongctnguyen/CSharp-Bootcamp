using System;

namespace Implicit_Explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 12434;
            long bigNum = num;

            float myFloat = 16.7f;
            double myNewDouble = myFloat;

            // explicit conversion
            // cast double to int
            double myDouble = 13.6;
            int myInt;

            myInt = (int)myDouble;

            // type conversion
            string myString = myDouble.ToString();

            string myString1 = "14";
            int num1 = Int32.Parse(myString1);

            Console.WriteLine(myInt);
            Console.WriteLine(myString.GetType());
            Console.WriteLine(num1.GetType());
        }
    }
}
