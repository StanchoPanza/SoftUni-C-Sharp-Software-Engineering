using System;

namespace SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double chemicals = double.Parse(Console.ReadLine()) * 5.80;
            double markers = double.Parse(Console.ReadLine()) * 7.20;
            double washliquid = double.Parse(Console.ReadLine()) * 1.20;
            double percentReduction = double.Parse(Console.ReadLine()) / 100;
            double totalPrice = chemicals + markers + washliquid;
            double discount = totalPrice * percentReduction;
            totalPrice -= discount;
            Console.WriteLine(totalPrice);
        }
    }
}
