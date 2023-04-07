using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Box
    {
        public int SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] currentItem = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int serialNumber = int.Parse(currentItem[0]);
                string itemName = currentItem[1];
                int quantity = int.Parse(currentItem[2]);
                decimal itemPrice = decimal.Parse(currentItem[3]);
                decimal totalPrice = quantity * itemPrice;

                Box box = new()
                {
                    SerialNumber = serialNumber,
                    ItemName = itemName,
                    Quantity = quantity,
                    ItemPrice = itemPrice,
                    TotalPrice = totalPrice
                };

                boxes.Add(box);

                input = Console.ReadLine();
            }
            List<Box> orderedList = boxes.OrderByDescending(p => p.TotalPrice).ToList();

            foreach (Box box in orderedList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.ItemPrice:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:F2}");
            }
        }
    }
}
