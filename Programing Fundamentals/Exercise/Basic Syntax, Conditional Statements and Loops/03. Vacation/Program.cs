using System;

namespace VacationV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double singlePrice = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            singlePrice = 8.45;
                            break;
                        case "Saturday":
                            singlePrice = 9.80;
                            break;
                        case "Sunday":
                            singlePrice = 10.46;
                            break;

                    }
                    if (peopleCount >= 30)
                    {
                        singlePrice *= 0.85;
                    }
                    break;
            }
            switch (groupType)
            {
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            singlePrice = 10.90;
                            break;
                        case "Saturday":
                            singlePrice = 15.60;
                            break;
                        case "Sunday":
                            singlePrice = 16;
                            break;
                    }
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }
                    break;
            }
            switch (groupType)
            {
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            singlePrice = 15;
                            break;
                        case "Saturday":
                            singlePrice = 20;
                            break;
                        case "Sunday":
                            singlePrice = 22.5;
                            break;
                    }
                    if (peopleCount > 9 && peopleCount < 21)
                    {
                        singlePrice *= 0.95;
                    }
                    break;
            }
            double totalPrice = peopleCount * singlePrice;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
