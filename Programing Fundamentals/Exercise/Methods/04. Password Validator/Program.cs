using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordChecker(password);
        }
        static void PasswordChecker(string pass)
        {
            bool lenght = true;
            bool characters = true;
            bool digits = true;
            int digitCount = 0;
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                lenght = false;
            }
            foreach (char c in pass)
            {
                if (char.IsLetterOrDigit(c))
                {
                    characters = true;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    characters = false;
                    break;
                }
            }
            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                    digitCount++;
            }
            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                digits = false;

            }
            if (lenght && characters && digits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
