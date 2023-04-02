using System;
using System.Linq;

namespace RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] roundednumbers = new int[nums.Length];

            
            for (int i = 0; i < nums.Length; i++) 
            {
                roundednumbers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{nums[i]} => {string.Join(' ', roundednumbers[i])}");
            }
            

        }
    }
}
