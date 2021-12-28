using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Characters
            char c = 'a';
            char d = '1';
            char s = '*';

            int i = sizeof(char); // i = 2

            // C# Strings
            string s1 = "hello";
            string s2 = "12345";
            string s3 = "***";

            Console.WriteLine("hello, world");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            // Different ways to represent strings
            // Literals
            string str1 = "world";
            // Verbatim
            string str2 = @"c:\myfolder\test.txt";
            // Interpolated
            string str3 = $"hello {str1}"; // hello world

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);



        }
    }
}
