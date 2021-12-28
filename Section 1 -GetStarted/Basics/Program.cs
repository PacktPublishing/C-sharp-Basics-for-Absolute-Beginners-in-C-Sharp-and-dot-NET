using System;

namespace Basics
{
    class Program
    {
        /// <summary>
        /// Basics of the C# language.
        /// </summary>
        static void Main(string[] args)
        {
            // C# Statements
            // Single instruction of code
            // Similar to English.
            // Ends with ;
            Console.WriteLine("Hello");

            // C# Blocks
            // Group of statements
            // Starts with { and ends with }
            if(true)
            {
                /* Checking if statement
                with some sample declarations
                End of multiline statements
                */
                int a = 100;
                int b = a;
            }

            // C# Comments
            // 3 types of comments
            // Single line comment //
            // Multiline comment /* */
            // Documentation comment ///

            // C# Read and Write
            string str = Console.ReadLine();
            Console.WriteLine("Hello, World");
            Console.Write("hello");
            Console.WriteLine(str);
        }
    }
}
