using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int totalPieces = width * length;
            int pieces = 0;

            while (totalPieces > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                pieces = int.Parse(input);
                totalPieces -= pieces;
            }
            if (totalPieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
        }
    }
}
