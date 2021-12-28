using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            // While loop
            Console.WriteLine("While Loop");
            int i = 0;
            while (i < input && i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }

            // Do While loop
            i = 0;
            Console.WriteLine("Do While Loop");
            do
            {
                Console.WriteLine(i);
                i++;
            }while(i < input && i < 5);

            // For loop
            Console.WriteLine("For Loop");
            for(int j = 0; j < input && j < 5; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("End of the program!");
        }
    }
}
