using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumLeft += number;
            }
            

            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumRight += number;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs (sumRight - sumLeft)}");
            }
        }
    }
}
