using System;

namespace AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = numbersSum(num1, num2);
            int result = subtractNum(sum, num3);

            Console.WriteLine(result);

        }
        static int numbersSum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;

        }
        static int subtractNum(int sum, int subtractor)
        {
            int result = sum - subtractor;
            return result;
        }
    }
}
