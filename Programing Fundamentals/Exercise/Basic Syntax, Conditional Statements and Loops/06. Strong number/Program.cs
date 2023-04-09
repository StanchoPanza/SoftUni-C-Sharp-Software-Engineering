using System;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long initNum = long.Parse(input);
            long sum = 0;
            foreach (var num in input)
            {
                long number = int.Parse(num.ToString());

                long factorial = 1;

                for (long i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }

            if (sum == initNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
