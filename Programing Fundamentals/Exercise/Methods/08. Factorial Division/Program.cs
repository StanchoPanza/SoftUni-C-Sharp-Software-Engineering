using System;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = int.Parse(Console.ReadLine());
            decimal num2 = int.Parse(Console.ReadLine());

            decimal num1Factorial = NumberFactorial(num1);
            decimal num2Factorial = NumberFactorial(num2);

            FactorialDivision(num1Factorial, num2Factorial);
        }
        static decimal NumberFactorial(decimal num1)
        {
            decimal result = num1;
            for (decimal i = num1 -1; i > 1; i--)
            {                
                result *= i;
            }return result;
        }
        static void FactorialDivision(decimal num1, decimal num2)
        {
            decimal result = num1 / num2;
            Console.WriteLine($"{result:F2}");
        }
    }
}
