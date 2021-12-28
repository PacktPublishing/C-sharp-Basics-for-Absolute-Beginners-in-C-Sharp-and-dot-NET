using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write C# code snippet read a positive number from the console and print the total number of digits in it.
            // For eg., 135 --> 3, 90 --> 2, 98788 --> 5
            // Note that you can use int.Parse(string) function to convert a string to integer. 
            
            // Declare the variables
            int i = 0;
            int count = 0;

            // Read the input and store in a variable 'i'
            string input = Console.ReadLine();
            i = int.Parse(input);
            
            // Loop through each time dividing by 10 to count the digits. 
            do
            {
                count++;
                i = i / 10;
            }while (i > 0);

            // Print to the console output
            Console.WriteLine(count);
        }
    }
}
