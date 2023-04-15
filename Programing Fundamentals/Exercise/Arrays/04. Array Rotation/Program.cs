using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstToLast = arr[0];
                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];

                }
                arr[arr.Length-1] = firstToLast;
            }
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
