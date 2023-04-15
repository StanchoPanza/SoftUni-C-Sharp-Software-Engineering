using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            int maxCount = 0;
            string numbers = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        numbers = arr[i].ToString();
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int j = 0; j <= maxCount; j++)
            {
                Console.Write(numbers + ' ');
            }
        }
    }
}
