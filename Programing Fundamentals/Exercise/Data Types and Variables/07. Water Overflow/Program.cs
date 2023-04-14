using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumOfLiters = 0;
            int capacity = 255;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sumOfLiters += liters;
               
                if (sumOfLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLiters -= liters;
                }
            }
            Console.WriteLine(sumOfLiters);
        }
    }
}
