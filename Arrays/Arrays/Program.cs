using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrays - a variable that can store multiple values + fixed size

            //String[] cars = { "BMW", "Mustang", "Tesla" };

            String[] cars = new string[3]; //accomodates values to index 3

            cars[0] = "Subaru"; //Updates item at index 0
            cars[1] = "Mustang";
            cars[2] = "Tesla";
            

            /*Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);*/

            //Easier method - write a for loop

            for (int i = 0; i < cars.Length; i++) //iterate to display the items
            {
                Console.WriteLine(cars[i]);
            }


            Console.ReadKey();
            Console.Beep();
        }
    }
}
