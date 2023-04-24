using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> initList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int num = int.Parse(command[1]);
                    initList.Add(num);
                }
                else if (command[0] == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index < 0 || index > initList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        initList.Insert(index, num);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > initList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        initList.RemoveAt(index);
                    }
                }
                else if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    ShiftLeft(initList, count);
                }
                else if (command[1] == "right")
                {
                    int count = int.Parse(command[2]);
                    ShiftRight(initList, count);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', initList));
        }

        static List<int> ShiftRight(List<int> input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNum = input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
                input.Insert(0, lastNum);
            }
            return input;
        }
        static List<int> ShiftLeft(List<int> input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNum = input[0];
                input.RemoveAt(0);
                input.Insert(input.Count, firstNum);
            }
            return input;
        }
    }
}
