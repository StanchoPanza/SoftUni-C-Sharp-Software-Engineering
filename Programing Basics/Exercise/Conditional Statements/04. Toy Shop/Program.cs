using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            double puzzlesCount = double.Parse(Console.ReadLine());
            double dollsCount = double.Parse(Console.ReadLine());
            double bearsCount = double.Parse(Console.ReadLine());
            double minnionsCount = double.Parse(Console.ReadLine());
            double trucksCount = double.Parse(Console.ReadLine());
            double totalCount = puzzlesCount + dollsCount + bearsCount + minnionsCount + trucksCount;
            double puzzlesPrice = puzzlesCount * 2.6;
            double dollsPrice = dollsCount * 3.0;
            double bearsPrice = bearsCount * 4.10;
            double minnionsPrice = minnionsCount * 8.20;
            double trucksPrice = trucksCount * 2;
            double totalPrice = puzzlesPrice + dollsPrice + bearsPrice + minnionsPrice + trucksPrice;
            if (totalCount >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }
            double totalIncome = totalPrice * 0.9;
            double left = totalIncome - priceTrip;
            if (left >= 0)
            {
                Console.WriteLine($"Yes! {left:F2} lv left.");
            }
            else
            {
                left = Math.Abs(left);
                Console.WriteLine($"Not enough money! {left:F2} lv needed.");
            }
            
        }
    }
}
