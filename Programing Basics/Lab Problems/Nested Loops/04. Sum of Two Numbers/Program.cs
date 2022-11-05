using System;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int combinationcount = 0;
            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    combinationcount++;
                    sum = i + j;

                    if (sum == c)
                    {
                        Console.WriteLine($"Combination N:{combinationcount} ({i} + {j} = {sum})");
                        return;
                    }
                }                          
            }
            Console.WriteLine($"{combinationcount} combinations - neither equals {c}");
        }
    }
}
