using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

           int num =  random.Next(1, 7); //displays a random integer
           int num2 = random.Next(1, 7);
           int num3 = random.Next(1, 7);
           double num4 = random.NextDouble(); //displays a random decimal between 0 and 1

            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);


            Console.ReadKey();

            Console.Beep();
        }
    }
}
