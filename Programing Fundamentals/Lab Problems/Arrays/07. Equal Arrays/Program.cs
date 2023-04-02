using System;
using System.Linq;

namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int notEqual = -1;
            int sum = 0;


            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] != arr2[i])
                {
                    notEqual = i;
                    break;
                }
                else
                {
                    sum += arr1[i];
                }

            }
            if (notEqual == -1)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {notEqual} index");
            }
        }
    }
}

