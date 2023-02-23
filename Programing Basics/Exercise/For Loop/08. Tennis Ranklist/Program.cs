using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int totalPoint = 0;
            double tournamentsWon = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string position = Console.ReadLine();
                if (position == "W")
                {
                    totalPoint += 2000;
                    tournamentsWon++;
                }
                else if (position == "F")
                {
                    totalPoint += 1200;
                }
                else if (position == "SF")
                {
                    totalPoint += 720;
                }
            }
            double avaragePoints = totalPoint / tournaments;

            Console.WriteLine($"Final points: {totalPoint + points}");
            Console.WriteLine($"Average points: {avaragePoints}");
            Console.WriteLine($"{tournamentsWon / tournaments * 100:F2}%");

        }
    }
}
