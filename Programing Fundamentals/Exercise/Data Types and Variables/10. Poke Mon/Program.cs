using System;

namespace Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            double fiftyPercent = power * 0.5;
            int pokeCount = 0;

            while (power >= distance)
            {
                power -= distance;
                pokeCount++;
                if (power == fiftyPercent && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
        }
    }
}
