using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double freeSits = double.Parse(Console.ReadLine());

            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;

            double currentTicketsSold = 0;
            double ticketsSold = 0;

            double seatsRemained = freeSits;

            string ticketType = "";

            bool flag = true;

            while (movieName != "Finish")
            {
                while (currentTicketsSold < freeSits)
                {
                    ticketType = Console.ReadLine();


                    if (ticketType == "End")
                    {
                        break;
                    }

                    switch (ticketType)
                    {
                        case "student":
                            studentCount++;
                            break;
                        case "standard":
                            standardCount++;
                            break;
                        case "kid":
                            kidCount++;
                            break;
                    }

                    currentTicketsSold++;
                    seatsRemained--;
                    ticketsSold++;
                }
                Console.WriteLine($"{movieName} - {currentTicketsSold / freeSits * 100:F2}% full.");
                movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }
                freeSits = double.Parse(Console.ReadLine());
                currentTicketsSold = 0;


            }
            Console.WriteLine($"Total tickets: {ticketsSold}");
            Console.WriteLine($"{studentCount / ticketsSold * 100:F2}% student tickets.");
            Console.WriteLine($"{standardCount / ticketsSold * 100:F2}% standard tickets.");
            Console.WriteLine($"{kidCount / ticketsSold * 100:F2}% kids tickets.");

        }
    }
}
