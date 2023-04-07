using System;
using System.Numerics;

namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger currentNum = 1;

            for (int i = num; i > 1; i--)
            {
                currentNum *= i;
            }
            Console.WriteLine(currentNum);
        }
    }
}
