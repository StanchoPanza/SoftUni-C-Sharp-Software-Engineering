using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int evenSum = GetSumOfEvenDigits(input);
            int oddSum = GetSumOfOddDigits(input);

            Console.WriteLine(GetMultipleOfEvenAndOdds(evenSum, oddSum));

        }

        public static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;
            foreach (var ch in input)
            {
                if (ch == '-')
                {
                    continue;
                }
                if (int.Parse(ch.ToString()) % 2 == 0)
                {
                    sum += int.Parse(ch.ToString());
                }
            }

            return sum;
        }

        public static int GetSumOfOddDigits(string input)
        {
            int sum = 0;
            foreach (var ch in input)
            {
                if (ch == '-')
                {
                    continue;
                }
                if (int.Parse(ch.ToString()) % 2 != 0)
                {
                    sum += int.Parse(ch.ToString());
                }
            }

            return sum;
        }

        public static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }

    }

}

