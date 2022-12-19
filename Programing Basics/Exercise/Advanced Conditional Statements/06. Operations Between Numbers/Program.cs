using System;

namespace OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string oddOrEven = "odd";

            double result = 0.00;
            if (operation == '+')
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                    Console.WriteLine($"{n1} + {n2} = {result} - {oddOrEven}");
                }
                else
                {
                    oddOrEven = "odd";
                    Console.WriteLine($"{n1} + {n2} = {result} - {oddOrEven}");
                }
            }
            if (operation == '-')
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                    Console.WriteLine($"{n1} - {n2} = {result} - {oddOrEven}");
                }
                else
                {
                    oddOrEven = "odd";
                    Console.WriteLine($"{n1} - {n2} = {result} - {oddOrEven}");
                }
            }
            if (operation == '*')
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                    Console.WriteLine($"{n1} * {n2} = {result} - {oddOrEven}");
                }
                else
                {
                    oddOrEven = "odd";
                    Console.WriteLine($"{n1} * {n2} = {result} - {oddOrEven}");
                }
            }
            if (operation == '/')
            {
                result = n1 / n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {result:F2}");
                }
            }
            if (operation == '%')
            {
                result = n1 % n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
        }
    }
}