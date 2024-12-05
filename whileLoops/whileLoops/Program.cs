using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String name = "";


            while (name == "")
            {

                Console.Write("Enter your name: ");
                name = Console.ReadLine();
               
            }

            Console.WriteLine("Hello " + name);
            Console.ReadKey();
            Console.Beep();

        }

        
    }
}
