using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;
            int coincount = 0;
            change = Math.Round(change);


            while (change > 0)
            {
                if (change >= 200)
                {
                    change -= 200;
                    coincount++;
                }
                if (change < 200 && change >= 100)
                {
                    change -= 100;
                    coincount++;
                }
                if (change < 100 && change >= 50)
                {
                    change -= 50;
                    coincount++;
                }
                if (change < 50 && change >= 20)
                {
                    change -= 20;
                    coincount++;
                }
                if (change < 20 && change >= 10)
                {
                    change -= 10;
                    coincount++;
                }
                if (change < 10 && change >= 5)
                {
                    change -= 5;
                    coincount++;
                }
                if (change < 5 && change >= 2)
                {
                    change -= 2;
                    coincount++;
                }
                if (change < 2 && change > 0)
                {
                    change -= 1;
                    coincount++;
                }


            }
            Console.WriteLine(coincount);
        }
    }
}
