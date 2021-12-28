using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Debugging
            //  - Process of locating bugs/issues and removing them using debugging tools.
            //  - Usually it takes more time to debug than coding!
            //  - Debugging is a part of every programmers day-to-day life.  

            // Print all even numbers below 10
            PrintEvenNumbers();
        }

        static void PrintEvenNumbers()
        {
            int input = 10;
            int i = 1;

            while (i < input) 
            {
                bool result = ((i / 2) == 0);
                if(!result)
                {
                    // Found an even number. 
                    // Print it. 
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
