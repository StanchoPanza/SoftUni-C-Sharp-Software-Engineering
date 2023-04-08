using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counter = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string toLower = item.ToLower();
                if (counter.ContainsKey(toLower))
                {
                    counter[toLower]++;
                }
                else
                {
                    counter.Add(toLower, 1);
                }
            }
            foreach (var item in counter)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
