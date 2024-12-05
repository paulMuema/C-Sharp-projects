using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 100)
            {
                Console.WriteLine("Sorry, you are too old to sign up");

               
            }
            else if(age <= 0)
            {
                Console.WriteLine("Age not valid");
            }
            else if(age >= 18)
            {
                Console.WriteLine("You are signed up! :)");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up");
            }
            Console.Beep();
            Console.ReadKey();
        }
    }
}
