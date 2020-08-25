using System;

namespace Enums
{
    enum Day {Mo, Tu, We, Th, Fr, Sa, Su};
    enum Month {Jan = 15, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};
    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Console.WriteLine($"{fr}");
            Console.WriteLine($"{(int)Day.Mo}");

            Console.WriteLine($"{(int)Month.Jan}");
            Console.WriteLine($"{Month.Feb}");
        }
    }
}
