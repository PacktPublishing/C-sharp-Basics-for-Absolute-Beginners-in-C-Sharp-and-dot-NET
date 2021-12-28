using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write C# code snippet to declare a character and assign value 'C'. 
            // Print the same to the Console.
            char ch;
            ch = 'C';
            Console.WriteLine(ch);

            // Exercise 2
            // Write C# code snippet to read a name as string from console
            // and print "Hello, " along with the name to the Console.
            string str;
            Console.WriteLine("Enter your name: ");
            str = Console.ReadLine();
            Console.WriteLine("Hello, " + str);

            // Exercise 3
            // Rewrite the solution of Exercise 2 to use string interpolation ('$')
            // to combine two strings instead of using the '+' symbol. 
            string str2;
            Console.Write("Enter your name: ");
            str2 = Console.ReadLine();
            Console.WriteLine($"Hello, {str2}"); 
        }
    }
}
