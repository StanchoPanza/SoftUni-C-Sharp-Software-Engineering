using System;

namespace SignofIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSign(number));
        }
        static string PrintSign(int number)
        {
            if (number > 0)
            {
                return $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                return $"The number {number} is negative.";
            }
                
            return $"The number {number} is zero.";            
        }
    }
}
