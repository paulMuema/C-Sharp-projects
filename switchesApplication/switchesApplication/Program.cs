using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchesApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a known planet in the solar system: ");
            string planet = Console.ReadLine();

            switch (planet)
            {
                case "Mercury":
                    Console.WriteLine("It is the first planet from the sun.");
                    break;
                case "Venus":
                    Console.WriteLine("It is the second planet from the sun.");
                    break;
                case "Earth":
                    Console.WriteLine("It is the third planet from the sun.");
                    break;
                case "Mars":
                    Console.WriteLine("It is the fourth planet from the sun.");
                    break;
                case "Jupiter":
                    Console.WriteLine("It is the fifth planet from the sun.");
                    break;
                case "Saturn":
                    Console.WriteLine("It is the sixth planet from the sun.");
                    break;
                case "Uranus":
                    Console.WriteLine("Hehe.\nIt is the seventh planet from the sun.");
                    break;
                case "Neptune":
                    Console.WriteLine("It is the eighth planet from the sun.");
                    break;
                case "Pluto":
                    Console.WriteLine("It is a dwarf planet.\nIt is not part of the solar system");
                    break;
                default:
                    Console.WriteLine(planet + " is not a known planet in the solar system");
                    break;
            }
            Console.Beep();
            Console.ReadKey();
        }
    }
}
