using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            SortedDictionary<int, int> counted = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (counted.ContainsKey(number))
                {
                    counted[number]++;
                }
                else
                {
                    counted.Add(number, 1);
                }

            }
            foreach (var number in counted)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
