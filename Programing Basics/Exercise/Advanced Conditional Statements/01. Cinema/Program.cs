using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            int seats = rows * colums;
            double ticketPrice = 0;

            switch (type)
            {
                case "Premiere":
                    ticketPrice = 12;

                     break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                default:
                    ticketPrice = 5.00;
                    break;
            }
            double totalPrice = seats * ticketPrice;

            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
