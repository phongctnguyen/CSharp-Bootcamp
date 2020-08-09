using System;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = -5;
            string stateOfMatter;

            stateOfMatter = temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is " + stateOfMatter);

            temp = 101;
            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is " + stateOfMatter);

            Console.Read();
        }
    }
}
