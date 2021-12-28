using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write C# code snippet to read an integer and print it if it is divisble by 3.
            // Note that you can use int.Parse(string) function to convert a string to integer.

            // Read the input from the console
            string input = Console.ReadLine();

            // Parse to convert the input string to integer
            int a = int.Parse(input);

            // Check for divisible by 3
            if(a % 3 == 0)
            {
                Console.WriteLine("The entered number is divisible by 3");
            }
            else
            {
                Console.WriteLine("The entered number is NOT divisible by 3");
            }

        }
    }
}
