﻿using System;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console - double USD
            //make calculations
            //print the result
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine(BGN);
        }
    }
}