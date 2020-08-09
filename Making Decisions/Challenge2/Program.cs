using System;

namespace Challenge2
{
    class Program
    {   
        static int highscore = 5;
        static string highscorePlayer = "Phong";
        static void Main(string[] args)
        {
            Console.Write("Enter player: ");
            string playerInput = Console.ReadLine();

            Console.Write("Enter score: ");
            int scoreInput = int.Parse(Console.ReadLine());

            CheckHighScore(playerInput, scoreInput);
            CheckHighScore("Adam", 6);
            Console.Read();
        }

        public static void CheckHighScore(string playerInput, int scoreInput)
        {
            if (scoreInput > highscore)
            {
                Console.WriteLine("New highscore is " + scoreInput);
                Console.WriteLine("New highscore holder is " + playerInput);
            }
            else 
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }

    }
}
