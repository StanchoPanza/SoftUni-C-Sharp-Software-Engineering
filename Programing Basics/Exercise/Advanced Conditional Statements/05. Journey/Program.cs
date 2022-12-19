using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double rent = 0.00;
            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    rent = budget * 0.30;
                }
                else
                {
                    place = "Hotel";
                    rent = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    rent = budget * 0.40;
                }
                else
                {
                    place = "Hotel";
                    rent = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                rent = budget * 0.90;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {rent:F2}");
        }
    }
}
