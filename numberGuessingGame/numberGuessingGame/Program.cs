using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// It allows the user to guess a number till they get it right and they 
// show how many guesses the person took
namespace numberGuessingGame
{
    internal class Program
    {//number guessing game
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true; //if the user wants to play again
            int min = 1; //Minimum value
            int max = 100;//Maximum value
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)/*Gives the user the option if they want to play again.
                              * Resets everything
                */
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);/*returns a random value within the range
                                                    */

                while(guess != number) //Sentinel loop
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
                    guesses++; //increases the guesses plus one - to give final guess number
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
                else 
                {
                    playAgain = false;
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
