using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(baseNum, power));
        }
        static double MathPower(double a, double b)
        {
            double result = 0;
            result = Math.Pow(a, b);
            return result;
        }
    }
}
