using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool playAgain = true;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = rand.Next(1, 101);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + 1 + " - " + 101 + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + "is to hight!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + "is to low!");
                    }
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again. \n please press key (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing! ... I guess");
        }
    }
}