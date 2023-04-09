using System;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalAssets = double.Parse(Console.ReadLine());
            double studentsCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalRobesPrice = studentsCount * robesPrice;

            double totalLightSabers = Math.Ceiling(studentsCount * 1.1);
            double totalLsPrice = lightSaberPrice * totalLightSabers;

            double freeBelts = Math.Floor(studentsCount / 6);
            double totalBeltPrice = (studentsCount - freeBelts) * beltsPrice;

            double totalFundsNeeded = totalLsPrice + totalRobesPrice + totalBeltPrice;

            if (totalAssets >= totalFundsNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFundsNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalFundsNeeded - totalAssets:F2}lv more.");
            }
        }
    }
}
