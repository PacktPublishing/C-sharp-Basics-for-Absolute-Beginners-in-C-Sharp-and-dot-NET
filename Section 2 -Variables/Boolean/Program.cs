using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b;
            b = true;

            Console.WriteLine("Before assignment");
            Console.WriteLine(b);

            b = bool.Parse(Console.ReadLine());
            Console.WriteLine("After assignment");
            Console.WriteLine(b);
        }
    }
}
