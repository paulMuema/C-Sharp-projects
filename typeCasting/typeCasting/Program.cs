using System;

namespace typeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* type casting - Converting a value to a different data type
             * Useful when accepting user input(string)
             * Different data types can do different things
             */

            double a = 3.14;
            int b = Convert.ToInt32(a); //double to integer truncates the .14

            int c = 123;
            double d = Convert.ToDouble(c) + 0.11; //integer to double plus adds decimal place + .11

            int e = 321;
            string f = Convert.ToString(e); //integer to string can no longer be used arithmatically

            string g = "@";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

         

            Console.WriteLine(b.GetType());
            Console.WriteLine(d);
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());

          

            Console.ReadKey();
        }
    }
}
