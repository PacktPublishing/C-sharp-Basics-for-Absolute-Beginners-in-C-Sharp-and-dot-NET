using System;

namespace Assignment4Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a simple C# calculator program to do basic mathematical operation (+, -, *, /)
            // by reading the type of operation and two values. Use switch statements to check 
            // the type of operation entered and print the result to the console. 

            // Display the instructions.
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            // Read the choice of operation.
            int choice = int.Parse(Console.ReadLine());

            // Read the two numbers and assign to a and b.
            Console.WriteLine("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            // The variable type used is decimal to hold fractional values in case of division.
            decimal result = 0;

            // Switch selection statement on the choice entered.
            switch (choice)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"Add : {result}");
                    break;
                case 2:
                    result = a - b;                    
                    Console.WriteLine($"Subtract : {result}");
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine($"Multiply : {result}");
                    break;
                case 4:
                    // Need to convert first variable to decimal, otherwise the fractional part will be lost in case of int variables. 
                    result = (decimal)a / b;
                    Console.WriteLine($"Divide : {result}");
                    break;
                default:
                    // Fallback option. Gets executed when user enters inputs other than expected. 
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
