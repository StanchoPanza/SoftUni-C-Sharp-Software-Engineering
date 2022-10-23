using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int maxNum = int.MinValue;

            while (num != "Stop")
            {
                int input = int.Parse(num);

                if (input > maxNum)
                {
                    maxNum = input;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
