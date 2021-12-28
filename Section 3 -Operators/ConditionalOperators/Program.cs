using System;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Conditional Operators

            bool a = false;
            bool b = true;

            Console.WriteLine($"a  b : {a} {b}");
            Console.WriteLine($"a && b : {a && b}");
            Console.WriteLine($"a || b : {a || b}");

            a = true;
            b = true;
            Console.WriteLine($"a  b : {a} {b}");
            Console.WriteLine($"a && b : {a && b}");
            Console.WriteLine($"a || b : {a || b}");

            a = false;
            b = false;
            Console.WriteLine($"a  b : {a} {b}");
            Console.WriteLine($"a && b : {a && b}");
            Console.WriteLine($"a || b : {a || b}");

        }
    }
}
