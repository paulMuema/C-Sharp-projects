using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nested loops - loops inside of other loops.
            /*Used in sorting algorithms - used to rearrange given array or list
             * elements according to a comparison operator on the elements*/
            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();
            /*In order to finish the outer iteration of the column we finish one 
            iteration of the inner loop.
            */
            for(int i = 0; i < rows; i++) //Outer Loop
            {
                for (int j = 0; j < columns; j++) //Inner Loop
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            
            
            Console.ReadKey();
            Console.Beep();




        }
    }
}
