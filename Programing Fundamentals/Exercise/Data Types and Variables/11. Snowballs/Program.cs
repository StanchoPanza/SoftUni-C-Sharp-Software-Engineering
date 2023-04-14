using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte ballsCount = byte.Parse(Console.ReadLine());

            BigInteger snowballMaxValue = 0;
            int snowballSnowMaxValue = 0;
            int snowballTimeMaxValue = 0;
            int snowballQualityeMaxValue = 0;

            for (int i = 1; i <= ballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > snowballMaxValue)
                {
                    snowballMaxValue = snowballValue;
                    snowballSnowMaxValue = snowballSnow;
                    snowballTimeMaxValue = snowballTime;
                    snowballQualityeMaxValue = snowballQuality;
                }


            }
            if (ballsCount == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine($"{snowballSnowMaxValue} : {snowballTimeMaxValue} = {snowballMaxValue} ({snowballQualityeMaxValue})");
            }

        }
    }
}
