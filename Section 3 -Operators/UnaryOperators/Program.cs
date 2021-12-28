using System;

namespace UnaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Unary operators.

            int a, b;

            a = 10;
            b = ++a;
            Console.WriteLine($"Prefix ++ , a = {a}, b = {b}");

            a = 10;
            b = a++;
            Console.WriteLine($"Postfix ++ , a = {a}, b = {b}");

            a = 10;
            b = --a;
            Console.WriteLine($"Prefix -- , a = {a}, b = {b}");

            a = 10;
            b = a--;
            Console.WriteLine($"Postfix -- , a = {a}, b = {b}");
        }
    }
}
