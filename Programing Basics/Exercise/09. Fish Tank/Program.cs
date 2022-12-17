using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {


            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggie = int.Parse(Console.ReadLine());

            double foodsum = chicken * 10.35 + fish * 12.40 + veggie * 8.15;
            Console.WriteLine(foodsum);
            double withDesert = (foodsum * 1.2) + 2.5;
            Console.WriteLine(withDesert);

        }
    }
}
