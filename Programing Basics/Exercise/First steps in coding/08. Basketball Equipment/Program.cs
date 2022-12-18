using System;

namespace Baketball
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double trainers = taxPerYear - (taxPerYear * 0.4);
            double outfit = trainers - (trainers * 0.2);
            double ball = outfit / 4;
            double acc = ball / 5;
            double expenses = taxPerYear + trainers + outfit + ball + acc;
            Console.WriteLine(expenses);
        }
    }
}
