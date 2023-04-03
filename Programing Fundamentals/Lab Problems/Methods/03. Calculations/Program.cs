using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (operation == "add")
            {
                Add(num1, num2);
            }
            else if (operation == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (operation == "subtract")
            {
                Subtract(num1, num2);
            }
            else
            {
                Divide(num1, num2);
            }
        }
        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}
