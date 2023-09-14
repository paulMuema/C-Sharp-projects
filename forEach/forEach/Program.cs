using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = simpler way to iterate over an array - but less flexible compared
            // to standard for loop - in standard you can change how they iterate - forwards,
            // backwards etc
            String[] cars = { "Subaru", "Toyota", "Jaguar" };
            //Standard for loop
            for (int i = 0; i > cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //for each loop
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
            Console.Beep();
        }
    }
}
