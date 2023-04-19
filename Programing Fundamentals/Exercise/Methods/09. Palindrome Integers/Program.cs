using System;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                ReversInput(input);
                input = Console.ReadLine();
            }
        }static void ReversInput(string input) 
        {
            string reversed = String.Empty;
            char[] charArray = input.ToCharArray();
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversed += charArray[i];
            }
            if (reversed == input)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

    }
}
