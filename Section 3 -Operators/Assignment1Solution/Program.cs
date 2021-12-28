using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to calculate (a-b)^2 by reading the values of a and b from the console. 
            // For eg., 
            //    (5-3)^2 = 4
            //    (10-6)^2 = 16
            // Note: The formula of (a-b)^2 = (a x a) + (b x b) - (2 x a x b)

            // Read the two numbers and assign to a and b.
            Console.WriteLine("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            // Do the calculation as per formula
            int result = (a*a) + (b*b) - (2*a*b);
            Console.WriteLine($"Result: {result}");
        }
    }
}
