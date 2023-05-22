using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsinAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            char[] charArray = input.ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in charArray)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (var symbol in dict)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
