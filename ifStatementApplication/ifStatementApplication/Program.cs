using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatementApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This calculates area of a cirlce.\nPlease enter a radius: ");
            
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius <= 0)
            {
                Console.WriteLine("Invalid input");
            }
           

           
            else 
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine("Your area is " + area);
            }
            Console.Beep();
            Console.ReadKey();
        }
        //How about if there's no input or input is random letters?
    }
}
