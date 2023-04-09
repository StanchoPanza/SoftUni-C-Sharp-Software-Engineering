using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double sum = 0;
            double productPrice = 0;

            while (coin != "Start")
            {
                double input = double.Parse(coin);
                if (coin == "0.1" || coin == "0.2" || coin == "0.5" || coin == "1" || coin == "2")
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                coin = Console.ReadLine();

            }

            string product = Console.ReadLine();

            while (product != "End")
            {

                switch (product)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }
                product = char.ToLower(product[0]) + product.Substring(1);
                if (sum >= productPrice)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }



            Console.WriteLine($"Change: {sum:F2}");

        }
    }
}
