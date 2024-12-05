using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifstatementExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name != "")
                {
                Console.WriteLine("Hello " + name);

            }
            else
            {
                Console.WriteLine("You did not enter a name lol!");
            }
            
            Console.Beep();
            Console.ReadKey();
        }
    }
}
