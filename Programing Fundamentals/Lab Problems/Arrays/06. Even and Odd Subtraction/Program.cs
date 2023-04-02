using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOdd = 0;
            int sumEven = 0;
            int result = 0;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
                result = sumEven - sumOdd;
            }
            Console.WriteLine(result);
        }
    }
}
