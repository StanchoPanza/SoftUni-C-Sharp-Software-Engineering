using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
            if (max == sum / 2)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                double diff = sum -= max;
                Console.WriteLine($"No\nDiff = {Math.Abs (diff - max)}");
            }
           
        }
    }
}
