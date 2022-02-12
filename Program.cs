using System;

namespace guess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;
            string word = "Family";
            int tries = 5;
            int guesses = 0;

            while (gameOn)
            {
                if (guesses != tries)
                {
                    Console.WriteLine("Enter guess");
                    string guess = Console.ReadLine();
                    if (guess == word)
                    {
                        Console.WriteLine("You won!, the word was " + word);
                        gameOn = false;
                    }
                    else if (guess != word)
                    {
                        Console.WriteLine("Wrong guess, try again");
                        guesses = guesses + 1;
                    }
                }
                else if (guesses == tries)
                {
                    Console.WriteLine("You lost!, the word was " + word);
                    gameOn = false;
                }
            }

            Console.ReadLine();
        }
    }
}
