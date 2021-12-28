using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Assignment Operators

            int a;

            a = 10;

            a += 5;
            Console.WriteLine($"a += 5 : {a}");

            a -= 5;
            Console.WriteLine($"a -= 5 : {a}");

            a *= 5;
            Console.WriteLine($"a *= 5 : {a}");

            a /= 5;
            Console.WriteLine($"a /= 5 : {a}");
        }
    }
}
