using System;

namespace Assignment3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write C# code snippet to check whether a entered password is valid or not as per below rules:
            //  - Password length between 8 and 14 (both inclusive)
            //  - At least 1 upper case letter
            //  - At least 1 lower case letter
            //  - At least 1 numeric letter.
            // For eg.,
            //  Password123 --> Valid
            //  hello9090 --> Invalid

            // These boolean variables will hold the result of each check
            bool isLengthValid = false;
            bool isUppercase = false;
            bool isLowercase = false;
            bool isNumeric = false;

            // Read the password as plain text
            string password = Console.ReadLine();

            // Check for password length
            if(password.Length >= 8 && password.Length <= 14) 
            {
                isLengthValid = true;
            }

            // Iterate through each character of the string
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                // Check for lower case
                if (char.IsLower(ch))
                {
                    isLowercase = true;
                }
                // Check for upper case
                if (char.IsUpper(ch))
                {
                    isUppercase = true;
                }
                // Check for numeric
                if (char.IsNumber(ch))
                {
                    isNumeric = true;
                }
            }

            // Check whether the password satisfies all conditions
            if(isLengthValid && isUppercase && isLowercase && isNumeric)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
        }
    }
}
