﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* for (int i = 0; i <= 20; i++) //Beginning statement;condition;increment by 1 
            {
                Console.WriteLine(i);


            }
           */
           for (int i = 10; i > 0; i-=1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("EX-PLOSSIIOONNN!");
            Console.ReadKey();
            Console.Beep();
        }
    }
}
