using System;
using System.Collections.Generic;

namespace ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < numOfProducts; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }
            products.Sort();

            for (int i = 0; i < numOfProducts; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
