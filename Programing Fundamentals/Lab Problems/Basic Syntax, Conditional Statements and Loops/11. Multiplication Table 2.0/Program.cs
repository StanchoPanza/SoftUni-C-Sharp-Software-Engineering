using System;

namespace MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplicator = int.Parse(Console.ReadLine());


            if (multiplicator > 10)
            {
                Console.WriteLine($"{num} X {multiplicator} = {num * multiplicator}");
                return;
            }
            else
            {
                for (int i = multiplicator; i <= 10; i++)
                {
                    int result = num * i;
                    Console.WriteLine($"{num} X {i} = {result}");
                }
            }

            
        }
    }
}
