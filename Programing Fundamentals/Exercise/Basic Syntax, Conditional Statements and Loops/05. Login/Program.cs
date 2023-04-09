using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string reverseUsername = "";
            int length;

            length = userName.Length - 1;

            while (length >= 0)
            {
                reverseUsername = reverseUsername + userName[length];
                length--;
            }

            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();
                if ((password == reverseUsername))
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }
                else if (password != reverseUsername && i <4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {userName} blocked!");
            
        }
    }
}
