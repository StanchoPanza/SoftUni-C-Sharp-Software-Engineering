using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            

            while (country != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double availableSum = 0;

                while (availableSum < budget)
                {                    
                    availableSum += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {country}!");
                country = Console.ReadLine();
            }
        }
    }
}
