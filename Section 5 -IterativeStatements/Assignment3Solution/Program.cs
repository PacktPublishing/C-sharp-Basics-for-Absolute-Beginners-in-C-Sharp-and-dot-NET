using System;

namespace Assignment3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write C# code snippet to print only the numbers from an array containing both integer and string values. 
            // For eg., 
            //  { "2", "Red", "67" } --> 2, 67
            //  { "Hello", "45", "12", "Rose" } --> 45, 12

            // Array declaration
            string[] array = new string[] {"2", "Red", "67"};
            
            int value;

            // Iterate through each array element and check for numeric value
            for (int j = 0; j < array.Length; j++)
            {
                if (int.TryParse(array[j], out value))
                {
                    // Found numeric value! Print it to the console output. 
                    Console.WriteLine(value);
                }
            }
        }
    }
}
