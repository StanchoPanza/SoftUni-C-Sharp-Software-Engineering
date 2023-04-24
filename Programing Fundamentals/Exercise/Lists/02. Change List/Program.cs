using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                int element = int.Parse(command[1]);


                if (command[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int possition = int.Parse(command[2]);

                    numbers.Insert(possition, element);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
