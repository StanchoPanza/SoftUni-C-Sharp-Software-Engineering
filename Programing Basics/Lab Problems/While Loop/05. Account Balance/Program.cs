using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "NoMoreMoney")
            {

                double num = double.Parse(input);
                

                

                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += num;

                Console.WriteLine($"Increase: {num:F2}");
                input = (Console.ReadLine());

            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
