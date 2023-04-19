using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    Exchange(index, ref array);

                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        MaxEven(array);
                    }
                    else
                    {
                        MaxOdd(array);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        MinEven(array);
                    }
                    else
                    {
                        MinOdd(array);
                    }
                }
                else if (command[0] == "first")
                {
                    FirstEvenOdd(array, command);
                }
                else if (command[0] == "last")
                {
                    LastEvenOdd(array, command);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");

        }



        static Array Exchange(int index, ref int[] array)
        {
            if (index > array.Length - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            int[] exchangedArray = new int[array.Length];
            int newArray = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                exchangedArray[newArray] = array[i];
                newArray++;
            }
            for (int k = 0; k <= index; k++)
            {
                    exchangedArray[newArray] = array[k];
                    newArray++;
            }
            array = exchangedArray;
            return array;


        }
        static void MaxEven(int[] array)
        {
            int index = -1;
            int maxNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] % 2 == 0 && array[i] >= maxNum)
                {
                    index = i;
                    maxNum = array[i];
                }

            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }
        static void MaxOdd(int[] array)
        {
            int index = -1;
            int maxNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] >= maxNum)
                {
                    index = i;
                    maxNum = array[i];
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }
        static void MinEven(int[] array)
        {
            int index = -1;
            int minNum = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] % 2 == 0 && array[i] <= minNum)
                {
                    index = i;
                    minNum = array[i];
                }

            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }
        static void MinOdd(int[] array)
        {
            int index = -1;
            int minNum = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] % 2 != 0 && array[i] <= minNum)
                {
                    index = i;
                    minNum = array[i];
                }

            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }
        static void FirstEvenOdd(int[] array, string[] command)
        {
            int count = int.Parse(command[1]);
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else if (command[2] == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        evenNumbers.Add(array[i]);
                        count--;
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
            }
            else if (command[2] == "odd")
            {
                if (count > array.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        oddNumbers.Add(array[i]);
                        count--;
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", oddNumbers)}]");
            }
        }
        static void LastEvenOdd(int[] array, string[] command)
        {
            int count = int.Parse(command[1]);
            List<int> evenNumbers = new List<int>(1);
            List<int> oddNumbers = new List<int>(1);

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else if (command[2] == "even")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        evenNumbers.Insert(0, array[i]);
                        count--;
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", evenNumbers)}]");
            }
            else if (command[2] == "odd")
            {
                if (count > array.Length)
                {
                    Console.WriteLine("Invalid count");
                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        oddNumbers.Insert(0, array[i]);
                        count--;
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine($"[{string.Join(", ", oddNumbers)}]");
            }
        }



    }
}
