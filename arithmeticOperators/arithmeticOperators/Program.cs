using System;


namespace arithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;
            //friends = friends + 2; increases by 3
            //friends += 2; increases by 2
            //friends++;   //found in loops increasing by 1

            //friends = friends - 1; decreases by 1
            //friends -= 1; decreases by 1
            //friends--; loops decreases by 1

            //friends = friends * 2; multiplies by 2
            //friends *= 2; multiplies by 2 - loops

            //friends = friends / 2; returns 2 coz integer
            //friends /= 2;

            int remainder = friends % 3; //Modulus function - Looks for remainder

            Console.WriteLine(remainder);

            //Console.WriteLine("Your number of friends are " + friends);

            Console.ReadKey();
            Console.Beep();
        }
    }
}
