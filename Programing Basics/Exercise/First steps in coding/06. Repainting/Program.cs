using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double safetyNylon = double.Parse(Console.ReadLine()) + 2;
            double nylonPrice = safetyNylon * 1.5;
            double paint = double.Parse(Console.ReadLine()) * 1.1;
            double paintPrice = paint * 14.5;
            double paintThinner = double.Parse(Console.ReadLine()) * 5.00;
            double hours = double.Parse(Console.ReadLine());
            double priceMaterials = nylonPrice + paintPrice + paintThinner + 0.4;
            double salary = (priceMaterials * 0.3) * hours;
            double totalPrice = (priceMaterials + salary);
            Console.WriteLine(totalPrice);
        }
    }
}
