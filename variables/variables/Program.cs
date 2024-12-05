using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 123; //initialization
            int y = 321; //declaration and initialization
            int z = x + y;

            Console.WriteLine("The first number is " + x);
            Console.ReadKey();
            Console.WriteLine("The second number is "+ y);
            Console.ReadKey();
            Console.WriteLine("The sum of the two numbers is " + z);

            Console.ReadKey();

            int age = 22; //whole integer
            double height = 300.5; //decimal number
            bool alive = true; //true or false only
            char symbol = '@'; //symbol - use single quotes
            String name = "Paul";

            Console.WriteLine("Ssup " + name);
            Console.ReadKey();
            Console.WriteLine("Your age is " + age);
            Console.ReadKey();
            Console.WriteLine("Your height is " + height + "cm");
            Console.ReadKey();
            Console.WriteLine("Are you alive? " + alive);
            Console.ReadKey();
            Console.WriteLine("Your symbol is " + symbol);
            Console.ReadKey();
            
            Console.ReadKey();

            String userName = symbol + " " + name;

            Console.WriteLine("Your username is: " + userName);
            Console.Beep();
            Console.ReadKey();
        }
    }
}
