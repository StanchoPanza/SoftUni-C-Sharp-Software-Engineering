using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(MathOperator(num1, operation, num2));
        }

        public static int MathOperator(int num1, string operation, int num2)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;

            }
            return 0;
        }
    }
}
