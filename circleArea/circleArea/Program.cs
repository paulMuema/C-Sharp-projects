using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates area of a circle\nEnter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine("Your circle area is " + area + "\nHave a nice day.");
            Console.ReadKey();

            Console.Beep();
        }
    }
}
