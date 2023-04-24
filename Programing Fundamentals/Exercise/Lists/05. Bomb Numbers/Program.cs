
using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombParameters[0];
            int power = bombParameters[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int index = i;
                    RemoveLeft(ref numbers, ref index, power);
                    RemoveRight(ref numbers, ref index, power);
                }
            }

            numbers.RemoveAll(x => x == bomb);
            var sum = numbers.Sum();

            Console.WriteLine(sum);
        }

        static List<int> RemoveLeft(ref List<int> initialList, ref int index, int power)
        {
            for (int i = 0; i < power; i++)
            {
                if (index <= 0)
                {
                    break;
                }
                initialList.RemoveAt(index - 1);
                index--;

            }
            return (initialList);

        }
        static List<int> RemoveRight(ref List<int> initialList, ref int index, int power)
        {
            for (int i = 0; i < power; i++)
            {
                if (index + 1 >= initialList.Count)
                {
                    break;
                }
                initialList.RemoveAt(index + 1);
                

            }
            return initialList;
        }
    }
}
