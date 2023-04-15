using System;
using System.Linq;

namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            bool notEqual = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;

                for (int l = 0; l < i; l++)
                {
                    left = left + arr[l];
                }
                for (int r = arr.Length-1; r > i; r--)
                {
                    right = right + arr[r];
                }

                if (left == right)
                {
                    notEqual = false;
                    Console.WriteLine(i);
                }
                else if (arr.Length < 2)
                {
                    notEqual = false;
                    Console.WriteLine("0");
                }

            }
            if (notEqual)
            {
                Console.WriteLine("no");
            }

        }
    }
}
