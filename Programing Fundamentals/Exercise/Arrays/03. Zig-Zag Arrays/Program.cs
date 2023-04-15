using System;
using System.Linq;

namespace Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] redNumbers = new int[n];
            int[] blueNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i == 0 || i % 2 == 0)
                {
                    redNumbers[i] = input[0];
                    blueNumbers[i] = input[1];
                }
                else
                {
                    redNumbers[i] = input[1];
                    blueNumbers[i] = input[0];
                }
            }
            Console.WriteLine(String.Join(' ', redNumbers));
            Console.WriteLine(String.Join(' ', blueNumbers));


        }
    }
}
