using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double fundsNeeded = double.Parse(Console.ReadLine());
            double fundsAvailable = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spendingCount = 0;

            while (fundsAvailable < fundsNeeded && spendingCount < 5)
            {
                string operation = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                dayCount++;

                if (operation == "spend")
                {
                    spendingCount++;

                    fundsAvailable -= sum;
                }
                if (fundsAvailable < 0)
                {
                    fundsAvailable = 0;
                }
                else if (operation == "save")
                {
                    spendingCount = 0;

                    fundsAvailable += sum;
                }

            }
            if (fundsAvailable >= fundsNeeded)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(dayCount);
            }
        }
    }
}
