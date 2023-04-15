using System;
using System.Linq;

namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] + arr[i] == magicNum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
            }
        }
    }
}
