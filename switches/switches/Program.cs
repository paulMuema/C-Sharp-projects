using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch - An alternative to many if statements
            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch(day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;

                default:
                    Console.WriteLine(day + " is not a day."); //the else statement in the end
                    break;
            }
            Console.Beep();
            Console.ReadKey();
        }
    }
}
