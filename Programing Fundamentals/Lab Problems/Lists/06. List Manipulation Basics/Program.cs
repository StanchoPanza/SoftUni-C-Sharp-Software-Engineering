using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    int number = int.Parse(input[1]);
                    list.Add(number);
                }
                if (input[0] == "Remove")
                {
                    int number = int.Parse(input[1]);
                    list.Remove(number);
                }
                if (input[0] == "RemoveAt")
                {
                    int index = int.Parse(input[1]);
                    list.RemoveAt(index);
                }
                if (input[0] == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    list.Insert(index, number);
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}
