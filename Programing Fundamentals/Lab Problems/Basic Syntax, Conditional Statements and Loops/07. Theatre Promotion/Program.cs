using System;

namespace TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int priceOfTicket = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (typeOfDay == "Weekday")
            {
                if (age > -1 && age < 19)
                {
                    priceOfTicket = 12;
                }
                else if (age < 65)
                {
                    priceOfTicket = 18;
                }
                else if (age < 123)
                {
                    priceOfTicket = 12;
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (age > -1 && age < 19)
                {
                    priceOfTicket = 15;
                }
                else if (age < 65)
                {
                    priceOfTicket = 20;
                }
                else if (age < 123)
                {
                    priceOfTicket = 15;
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (age > -1 && age < 19)
                {
                    priceOfTicket = 5;
                }
                else if (age < 65)
                {
                    priceOfTicket = 12;
                }
                else if (age < 123)
                {
                    priceOfTicket = 10;
                }
            }
            
            Console.WriteLine($"{priceOfTicket}$");
        }
    }
}
