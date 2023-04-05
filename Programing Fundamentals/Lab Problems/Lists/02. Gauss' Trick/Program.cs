using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int lastIndex = numbers.Count - 1;

            for (int i = 0; i < lastIndex; i++)
            {               

                numbers[i] += numbers[lastIndex];
                numbers.RemoveAt(lastIndex);
                lastIndex--;
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
