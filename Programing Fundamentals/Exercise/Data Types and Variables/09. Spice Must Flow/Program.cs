using System;
using System.Numerics;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger yield = uint.Parse(Console.ReadLine());

            BigInteger spiceMined = 0;
            BigInteger daysMined = 0;

            if (yield < 100)
            {
                Console.WriteLine("0");
                Console.WriteLine("0");
                return;
            }
            else
            {
                while (yield >= 100)
                {
                    spiceMined += yield;
                    spiceMined -= 26;
                    yield -= 10;
                    daysMined++;
                }

            }
            Console.WriteLine(daysMined);
            Console.WriteLine(spiceMined - 26);

        }
    }
}
