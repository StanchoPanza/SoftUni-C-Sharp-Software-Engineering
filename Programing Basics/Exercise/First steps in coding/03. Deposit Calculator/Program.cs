﻿using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse (Console.ReadLine());

            double interest = depositSum * (percent / 100);
            double interestPerMonth = interest / 12;
            double sum = depositSum + months * interestPerMonth;
            Console.WriteLine(sum);
        }
    }
}
