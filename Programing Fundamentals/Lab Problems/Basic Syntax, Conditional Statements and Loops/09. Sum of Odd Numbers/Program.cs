using System;

namespace SumofOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int num = 1;
            int oddCount = 0;

            while (oddCount < count)
            {
                if (num % 2 != 0)
                {
                    oddCount++;
                    Console.WriteLine(num);
                    oddSum += num;
                }
                num++;
            }
            Console.WriteLine($"Sum: {oddSum}");

        }
    }
}
