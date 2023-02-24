using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int oddSum;
            int evenSum;

            string currentNum;

            for (int i = num1; i <= num2; i++)
            {
                oddSum = 0;
                evenSum = 0;

                currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0) 
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
