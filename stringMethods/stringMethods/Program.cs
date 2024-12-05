using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Paul Muema";
            //String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper(); All Caps
            //fullName = fullName.ToLower(); All small

            //phoneNumber = phoneNumber.Replace("-",""); //Replaces characters
            //Console.WriteLine(phoneNumber);
            //Console.WriteLine(fullName);

            //String userName = fullName.Insert(0, "Dr."); //index
            //Console.WriteLine(userName);

            Console.WriteLine(fullName.Length); 

            String firstName = fullName.Substring(0, 4); //Displays Paul as first name
            String lastName = fullName.Substring(5, 5);  //Displays Muema as last name

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.Beep();
            Console.ReadKey();
        }
    }
}
