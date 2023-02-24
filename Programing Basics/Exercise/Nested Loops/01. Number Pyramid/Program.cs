using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int currentNum = 1;

            bool isBigger = false;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNum > num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;


                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
