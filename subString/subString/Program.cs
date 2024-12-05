using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the owner's name: ");
            String fullName = Console.ReadLine();
            String firstName = fullName.Substring(0, 4);
            String lastName = fullName.Substring(5, 5);

            Console.WriteLine("Your first name is " + firstName);
            Console.WriteLine("Your last name is " + lastName + "\nHave a good day");

            Console.Beep();
            Console.ReadKey();






        }
    }
}
