using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int currentNum = int.Parse(input);
            int sum = 0;
            

            for (int i = 1; i <= input.Length; i++)
            {
                sum += currentNum % 10;
                currentNum /= 10;
            }Console.WriteLine(sum);
        }
    }
}
