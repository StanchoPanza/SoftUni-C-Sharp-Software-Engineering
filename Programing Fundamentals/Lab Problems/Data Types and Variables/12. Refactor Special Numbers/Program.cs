using System;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = 0;
            bool result = false;
            for (int ch = 1; ch <= input; ch++)
            {
                temp = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", temp, result);
                sum = 0;
                ch = temp;
            }

        }
    }
}
