using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double sum = 0;
            double money = 0;
            int toyCount = 0;


            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    money += 10;
                    sum += money - 1;
                }
                else
                {
                    toyCount++;
                }
            }
            double totalSum = toyPrice * toyCount + sum;
            if (totalSum >= priceWash)
            {
                Console.WriteLine($"Yes! {totalSum - priceWash:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWash - totalSum:F2}");
            }
        }
    }
}
