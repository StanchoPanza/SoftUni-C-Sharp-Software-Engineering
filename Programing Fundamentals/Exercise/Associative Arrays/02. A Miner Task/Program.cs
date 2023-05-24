using System;
using System.Collections.Generic;

namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> materials = new Dictionary<string, long>();
            while (true)
            {
                string material = Console.ReadLine();
                
                if (material == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (materials.ContainsKey(material))
                {
                    materials[material] += quantity;
                }
                else
                {
                    materials.Add(material, quantity);
                }
            }
            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
