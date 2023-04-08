using System;
using System.Text;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < input[i].Length; k++)
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
}
