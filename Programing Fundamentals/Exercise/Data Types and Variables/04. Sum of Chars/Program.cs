using System;

namespace SumofChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());

            int sumOfChars = 0;

            for (int i = 1; i <= lines; i++)
            {
                string c = Console.ReadLine();
                char c2 = char.Parse(c);
                sumOfChars += c2;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
