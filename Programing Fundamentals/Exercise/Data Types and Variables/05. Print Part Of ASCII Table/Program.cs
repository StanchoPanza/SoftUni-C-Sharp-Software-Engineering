using System;

namespace _5._PrintPartoftheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte stop = byte.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                char currChar = (char)i;
                Console.Write($"{currChar} ");
            }
        }
    }
}
