using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse (Console.ReadLine());
            double videoCard = double.Parse(Console.ReadLine());
            double processors = double.Parse(Console.ReadLine());
            double ramMemory = double.Parse(Console.ReadLine());
            
            double priceVideo = videoCard * 250;
            double priceProcessor = processors * (priceVideo * 0.35);
            double priceMemory = ramMemory * (priceVideo * 0.10);
            double totalPrice = priceVideo + priceProcessor + priceMemory;
            if (videoCard > processors)
            {
                totalPrice *= 0.85;

            }
            double result = budget - totalPrice;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {result:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(result):F2} leva more!");
            }
        }
    }
}
