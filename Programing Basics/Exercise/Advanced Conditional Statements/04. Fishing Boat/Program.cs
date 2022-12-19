using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double rent = 0.00;

            switch (season)
            {
                case "Spring":
                    rent = 3000.00;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200.00;
                    break;
                case "Winter":
                    rent = 2600.00; 
                        break;
            }
            if (fishermanCount <= 6)
            {
                rent -= rent * 0.10;
            }
            else if (fishermanCount <= 11)
            {
                rent -= rent * 0.15;
            }
            else
            {
                rent -= rent * 0.25;
            }
            if (fishermanCount % 2 == 0 && season != "Autumn")
            {
                rent -= rent * 0.05;
            }
            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {budget - rent:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs (budget - rent):F2} leva.");
            }
        }
    }
}
