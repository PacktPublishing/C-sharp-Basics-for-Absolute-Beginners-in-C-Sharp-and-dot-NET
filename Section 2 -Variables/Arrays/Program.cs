using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string sun = "sunday";
            string mon = "monday";

            string[] days = new string[] 
                {
                    "Sunday",
                    "Monday",
                    "Tuesday",
                    "Wedneday",
                    "Thursday",
                    "Friday",
                    "Saturday"
                };
            
            Console.WriteLine(days[0]);
            Console.WriteLine(days[1]);
            Console.WriteLine(days[2]);

            string[] daysNew;
            daysNew = new string[7];
            daysNew[0] = "Sunday";
            daysNew[1] = "Monday";
            daysNew[2] = "Tuesday";
            Console.Write(daysNew[0]);
            Console.Write(daysNew[1]);
            Console.Write(daysNew[2]);

            int length = daysNew.Length;  
            Console.WriteLine(length);          
        }
    }
}
