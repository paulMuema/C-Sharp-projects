using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorProgram
{
    internal class Program
    {
        //A Basic Calculator Program
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;


                Console.WriteLine("***************");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("***************");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine()); //Convert string to double

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add"); // \t creates a tab option
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not one of the options");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y for yes, N for No)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Have a nice day");

            Console.ReadKey();
            Console.Beep();

        }
    }
}
