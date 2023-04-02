using System;
using System.Linq;

namespace CondenseArraytoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = numArray.Length;

            while (numArray.Length > 1)
            {
                int[] sumArrey = new int[numArray.Length - 1];
                for (int i = 0; i < numArray.Length - 1; i++)
                {
                    sumArrey[i] = numArray[i] + numArray[i + 1];
                }
                numArray = sumArrey;
            }

            Console.WriteLine(numArray[0]);

        }
    }
}
