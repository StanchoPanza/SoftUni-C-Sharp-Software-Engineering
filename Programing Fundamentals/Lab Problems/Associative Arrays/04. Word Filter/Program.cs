using System;
using System.Linq;

namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, input));
        }
    }
}
