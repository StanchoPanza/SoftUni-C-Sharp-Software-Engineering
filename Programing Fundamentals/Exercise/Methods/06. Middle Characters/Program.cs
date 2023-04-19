using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length % 2 == 0)
            {
                evenCharacters(input);
            }
            else
            {
                oddCharacter(input);
            }
        }
        static void evenCharacters(string input)
        {
            int result = input.Length / 2;
            Console.WriteLine($"{input[result - 1]}{input[result]}");
        }
        static void oddCharacter(string input)
        {
            int result = (input.Length / 2);

            Console.WriteLine(input[result]);
        }

    }
}
