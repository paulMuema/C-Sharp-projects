using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuboidVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This calculates volume of a cuboid\nInput radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Input height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            
            double volume = Math.PI * radius * radius * height;
            Console.WriteLine("The volume of your cuboid is: " + volume + "\nHave a nice day");

            Console.ReadKey();
            
            Console.Beep();
        }
    }
}
