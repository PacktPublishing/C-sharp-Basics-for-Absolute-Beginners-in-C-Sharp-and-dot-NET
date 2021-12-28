using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foreach statement demo

            string[] days = new string[]
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            foreach(string s in days)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("End of the program");
        }
    }
}
