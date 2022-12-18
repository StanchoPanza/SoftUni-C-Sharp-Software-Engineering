using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            double runTime = double.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double timeAvailable = (breakTime * 0.625);
                        
            if (timeAvailable >= runTime)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeAvailable - runTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(runTime - timeAvailable)} more minutes.");
            }
        }
    }
}
