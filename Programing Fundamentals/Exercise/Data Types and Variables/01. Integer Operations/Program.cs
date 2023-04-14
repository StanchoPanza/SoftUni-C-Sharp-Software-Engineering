using System;
using System.Numerics;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long sum = (long)num1 + num2;
            long dividend = sum / (long)num3;
            long multiplicand = dividend * (long)num4;

            Console.WriteLine(multiplicand);

        }
    }
}
