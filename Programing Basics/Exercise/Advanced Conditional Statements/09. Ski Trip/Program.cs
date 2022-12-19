using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string posNeg = Console.ReadLine();

            double roomForOne = 18.00;
            double apartment = 25.00;
            double president = 35.00;

            int nights = days - 1;

            double totalSum = 0;

            if (typeOfRoom == "room for one person")
            {
                totalSum = nights * roomForOne;
            }

            if (typeOfRoom == "apartment")
            {
                if (days < 10)
                {
                    totalSum = nights * apartment * 0.7;
                }
                else if (days <= 15)
                {
                    totalSum = nights * apartment * 0.65;
                }
                else
                {
                    totalSum = nights * apartment * 0.50;
                }
            }
            if (typeOfRoom == "president apartment")
            {
                if (days < 10)
                {
                    totalSum = nights * president * 0.90;
                }
                else if (days <= 15)
                {
                    totalSum = nights * president * 0.85;
                }
                else
                {
                    totalSum = nights * president * 0.8;
                }
            }
            if (posNeg == "positive")
            {
                totalSum *= 1.25;
            }
            else if (posNeg == "negative")
            {
                totalSum *= 0.9;
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
