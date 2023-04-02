using System;
using System.Numerics;

namespace ConvertMeterstoKilometers
{
    internal class Program
    {
        public static BigInteger BigInteger { get; private set; }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                if (Int32.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (Char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();

            }

        }
    }
}
