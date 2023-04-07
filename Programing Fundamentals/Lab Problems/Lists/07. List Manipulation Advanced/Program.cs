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

            bool isChanged = false;
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    int number = int.Parse(input[1]);
                    list.Add(number);
                    isChanged = true;
                }
                if (input[0] == "Remove")
                {
                    int number = int.Parse(input[1]);
                    list.Remove(number);
                    isChanged = true;
                }
                if (input[0] == "RemoveAt")
                {
                    int index = int.Parse(input[1]);
                    list.RemoveAt(index);
                    isChanged = true;
                }
                if (input[0] == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    list.Insert(index, number);
                    isChanged = true;
                }
                if (input[0] == "Contains")
                {
                    if (list.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    
                    input = Console.ReadLine().Split();
                    continue;

                }
                if (input[0] == "PrintEven")
                {
                    List<int> result = new List<int>();

                    foreach (var num in list)
                    {
                        if (num % 2 == 0)
                        {
                            result.Add(num);
                                
                        }

                    }
                    Console.WriteLine(String.Join(" ", result));
                    input = Console.ReadLine().Split();
                    continue;

                }

                if (input[0] == "PrintOdd")
                {
                    List<int> result = new List<int>();

                    foreach (var num in list)
                    {
                        if (num % 2 != 0)
                        {
                            result.Add(num);
                                
                        }

                    }
                    Console.WriteLine(String.Join(" ", result));
                    input = Console.ReadLine().Split();
                    continue;

                }
                if (input[0] == "GetSum")
                {
                    int sum = 0;
                    foreach (var num in list)
                    {
                        sum += num;
                    }
                    Console.WriteLine(sum);
                    input = Console.ReadLine().Split();
                    continue;
                }
                if (input[0] == "Filter")
                {
                    string condition = input[1];
                    int num = int.Parse(input[2]);
                    Console.WriteLine(FilterList(list, condition, num));
                    input = Console.ReadLine().Split();
                    continue;

                }
                input = Console.ReadLine().Split();
                continue;

            }


             list.SequenceEqual(list);

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", list));
            }            
        }
        static string FilterList(List<int> list, string condition, int number)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (condition == "<")
                {
                    if (list[i] < number)
                    {
                        result.Add(list[i]);
                        continue;
                    }
                }
                if (condition == ">")
                {
                    if (list[i] > number)
                    {
                        result.Add(list[i]);
                        continue;
                    }
                }
                if (condition == "<=")
                {
                    if (list[i] <= number)
                    {
                        result.Add(list[i]);
                        continue;
                    }
                }
                if (condition == ">=")
                {
                    if (list[i] >= number)
                    {
                        result.Add(list[i]);
                        continue;
                    }
                }

            }
            return String.Join(" ", result);
        }
    }
}
