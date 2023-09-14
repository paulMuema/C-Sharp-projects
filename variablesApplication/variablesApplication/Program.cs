using System;

namespace variablesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 100000;
            int expenditure = 60000;
            int balance = salary - expenditure;
            string name = "Paul Muema";
            char symbol1 = '@';
            string email = "pkmuema";
            string emailName = email + symbol1 + "gmail" + ".com";

            Console.WriteLine("Good Morning " + name);
            Console.ReadKey();
            Console.WriteLine("Your email address is " + emailName);
            Console.ReadKey();
            Console.WriteLine("Your salary is " + salary);
            Console.ReadKey();
            Console.WriteLine("Your expenditure is " + expenditure);
            Console.ReadKey();
            Console.WriteLine("Your balance amount is " + balance);
            Console.ReadKey();
            Console.WriteLine("You should probably save.\nHave a good day!");
            Console.ReadKey();
            Console.Beep();
            


        }
    }
}
