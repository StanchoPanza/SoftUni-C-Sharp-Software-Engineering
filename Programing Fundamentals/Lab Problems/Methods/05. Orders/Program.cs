using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            

            for (int i = 1; i <= orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                double daysInMonth = double.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());

                double coffiePrice = (daysInMonth * capsulesCount) * pricePerCapsule;

                totalPrice += coffiePrice;

                Console.WriteLine($"The price for the coffee is: ${coffiePrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
