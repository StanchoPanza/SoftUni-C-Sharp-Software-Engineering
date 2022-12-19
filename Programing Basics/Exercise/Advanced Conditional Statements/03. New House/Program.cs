using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0.00;

            if (flowers == "Roses")
            {
                price = count * 5.00;

                if (count > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = count * 3.80;
                if (count > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                price = count * 2.80;
                if (count > 80)
                {
                    price = price - price * 0.15;
                }
                

            }
            else if (flowers == "Narcissus")
            {
                price = count * 3.00;
                if (count < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else
            {
                price = count * 2.50;
                if (count < 80)
                {
                    price = price + price * 0.20;
                }
            }
            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {Math.Abs(price - budget):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}
