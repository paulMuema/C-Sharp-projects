using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceExercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adds two numbers first then adds a third one

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum1 = num1 + num2;
            Console.Write("Enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double result = sum1 * num3;
            Console.WriteLine("Your final result is " + result);

            Console.ReadKey();
            Console.Beep();
        }
        //Add and Multiply Method
        
    }
    
}
