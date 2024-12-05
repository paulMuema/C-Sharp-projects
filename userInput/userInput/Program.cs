using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); /* Converts string to integer
                                                            * Format exception will occur
                                                            * When user inputs another data type
                                                            * Futre lesson - Handling exceptions
                                                            */

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");

            Console.ReadKey();
            Console.Beep();
        }
    }
}
