using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGuessingGame
{
    internal class Program
    {//number guessing game
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if(guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else if (response == "N")
                {
                    playAgain = false;
                }
                else
                {
                    Console.Write("Respond Y for Yes or N For No");
                    

                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
            Console.Beep();
        }

        /*Things to check in the program:
         * 1. When the user inputs sth thats not an integer
         * 2. When the user's response is not a Yes or No.
         */
    }
}
