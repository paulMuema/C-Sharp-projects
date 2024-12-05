using System;

namespace inputApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning.\nInput your salary amount: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your expenditure amount: ");
            int expenditure = Convert.ToInt32(Console.ReadLine());
            int balance = salary - expenditure;

            Console.WriteLine("Your balance is: " + balance + "\nRemember to save.\nHave a nice day!");
            Console.Beep();

        }
    }
}
