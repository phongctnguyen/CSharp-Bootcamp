﻿using System;

namespace Random_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }

        }
    }
}
