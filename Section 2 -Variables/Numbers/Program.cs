using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Whole numbers
            int i = 10;
            Console.WriteLine(i);
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(j);

            short s = 100;
            long l = 10000L;
            uint ui = 12;

            int intNum = (int)l;
            short shortNum = (short)i;

            // Decimal numbers
            float f = 10.5f;
            double d = 123.99;
            decimal dd = 345.80m;

            float floatNew = (float)dd;
            decimal decimalNew = (decimal)f;
            decimal decimalNew2 = (decimal)d;
        }
    }
}

