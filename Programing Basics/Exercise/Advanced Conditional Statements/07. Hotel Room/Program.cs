using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int accomods = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double appartPrice = 0;
            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                appartPrice = 65;
                if (accomods > 7 && accomods <= 14)
                {
                    studioPrice *= 0.95;
                }
                else if (accomods > 14)
                {
                    studioPrice *= 0.7;
                }
            }
            if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                appartPrice = 68.70;
                if (accomods > 14)
                {
                    studioPrice *= 0.8;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                appartPrice = 77;
            }
            if (accomods > 14)
            {
                appartPrice *= 0.9;
            }
            double sumAppart = accomods * appartPrice;
            double sumStudio = accomods * studioPrice;
            Console.WriteLine($"Apartment: {sumAppart:F2} lv.");
            Console.WriteLine($"Studio: {sumStudio:F2} lv.");
        }
    }
}
