using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int minNum = int.MaxValue;

            while (num != "Stop")
            {
                int input = int.Parse(num);

                if (input < minNum)
                {
                    minNum = input;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
