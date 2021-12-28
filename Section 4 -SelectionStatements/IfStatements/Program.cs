using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to get favourite subject option from user and print the subject name to the console.
        
            char ch;

            Console.WriteLine("Enter your favourite subject option: ");
            ch = (char)Console.Read();

            if(ch == 'e')
            {
                Console.WriteLine("Favourite subject is English");
            }
            else if(ch == 'm')
            {
                Console.WriteLine("Favourite subject is Maths");
            }
            else if(ch == 's')
            {
                Console.WriteLine("Favourite subject is Science");
            }
            else
            {
                Console.WriteLine("Other options than my favourite!");
            }

            Console.WriteLine("End of the program");
        }
    }
}
