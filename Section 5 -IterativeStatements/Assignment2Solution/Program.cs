using System;

namespace Assignment2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write C# code snippet to read a positive integer from the console and print it's factorial value. 
            // Factorial of a number refers to product of all numbers below it. 
            // For eg., 
            //  factorial(3) = 3 * 2 * 1 = 6
            //  factorial(5) = 5 * 4 * 3 * 2 * 1 = 120

            // Variable declarations
            int a;
            int result = 1;

            // Read the input and store in a variable 'a'
            string s = Console.ReadLine();
            a = int.Parse(s);

            while (a > 0)
            {
                result = result * a;
                a--;
            }

            // Print the result to the console output
            Console.WriteLine(result);
        }
    }
}
