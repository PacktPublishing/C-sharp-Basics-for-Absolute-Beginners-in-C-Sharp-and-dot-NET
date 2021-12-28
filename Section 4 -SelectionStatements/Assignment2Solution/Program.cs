using System;

namespace Assignment2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assume a variable phonePrice of type integer for holding the price of a phone in dollars.
            // Write a sequence of C# selection statements to print “budget” or “mid-range” or “high end”  based on the 
            // price range of the phone - less than 300, between 300 and 800, and more than 800 - respectively

            decimal phonePrice;

            string input = Console.ReadLine();
            phonePrice = decimal.Parse(input);

            // Note: Compiler infers decimal suffic m or M from variable type phonePrice
            if(phonePrice < 300)
            {
                Console.WriteLine("budget");
            }
            // Note: M for decimal can be appended
            else if(phonePrice >= 300M && phonePrice <= 800M)
            {
                Console.WriteLine("mid-range");
            }
            // Note: m for decimal can be in lower case as well
            else if(phonePrice > 800m)
            {
                Console.WriteLine("high end");
            }
        }
    }
}
