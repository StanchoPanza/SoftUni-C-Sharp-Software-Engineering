using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = ("s3cr3t!P@ssw0rd");
            string password = Console.ReadLine();
            if (pass == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}