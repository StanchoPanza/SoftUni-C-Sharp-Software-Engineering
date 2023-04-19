using System;
using System.Linq;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string topOfRange = Console.ReadLine();

            TopNumbers(topOfRange);
        }
        static void TopNumbers(string num)
        {
            int value = int.Parse(num);

            for (int i = 8; i <= value; i++)
            {
                int sum = 0;
                int[] currentNumArray = i.ToString().Select(x => int.Parse(x.ToString())).ToArray();
                bool thereisOdd = false;

                for (int j = 0; j < currentNumArray.Length; j++)
                {
                    
                    sum += currentNumArray[j];

                    if (currentNumArray[j] % 2 != 0)
                    {
                        thereisOdd = true;
                    }
                    
                }
                if (sum % 8 == 0 && thereisOdd == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
