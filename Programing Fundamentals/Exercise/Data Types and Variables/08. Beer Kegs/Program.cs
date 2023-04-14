using System;
using System.Numerics;

namespace BeerKegs
{
    internal class Program
    {
        public static object BigInteger { get; private set; }

        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            decimal kegMaxCapacity = 0;
            string maxCapKeg = "";

            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal kegCapacity = (decimal)(Math.PI * Math.Pow(radius, 2) * height);

                if (kegCapacity > kegMaxCapacity)
                {
                    kegMaxCapacity = kegCapacity;
                    maxCapKeg = kegName;
                }
            }
            Console.WriteLine(maxCapKeg);
        }
    }
}
