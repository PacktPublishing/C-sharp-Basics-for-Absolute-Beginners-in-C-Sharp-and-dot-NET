using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to get favourite subject option from user and print the subject name to the console.

            char ch;

            Console.WriteLine("Enter your favourite subject option: ");
            ch = (char)Console.Read();

            switch(ch)
            {
                case 'e':
                {
                    Console.WriteLine("Favourite subject is English");
                    break;
                }
                case 'm':
                {
                    Console.WriteLine("Favourite subject is Maths");
                    break;
                }
                case 's':
                {
                    Console.WriteLine("Favourite subject is Science");
                    break;
                }
                default:
                {
                    Console.WriteLine("Other than favourites!");
                    break;
                }
            }
        }
    }
}
