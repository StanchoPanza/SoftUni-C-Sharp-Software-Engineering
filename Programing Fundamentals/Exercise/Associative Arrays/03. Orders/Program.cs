using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders_Fundamentals
{
    public class Product
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Product> products = new List<Product>();
            while (input != "buy")
            {
                string[] product = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string productName = product[0];
                decimal productPrice = decimal.Parse(product[1]);
                decimal quantity = decimal.Parse(product[2]);

                if (products.Any(x => x.Name == productName))
                {
                    var productToUpdate = products.FirstOrDefault(x => x.Name == productName);
                    productToUpdate.Quantity += quantity;
                    productToUpdate.Price = productPrice;
                }
                else
                {
                    Product currentproduct = new Product(productName, productPrice, quantity);
                    products.Add(currentproduct);
                }
                input = Console.ReadLine();
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} -> {item.Quantity * item.Price:F2}");
            }
        }
    }
}
