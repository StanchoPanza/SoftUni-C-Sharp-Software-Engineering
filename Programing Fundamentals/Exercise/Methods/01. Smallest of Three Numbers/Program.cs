using System;

namespace SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            SmallestofThree(num1, num2, num3);

        }
        static void SmallestofThree(int a, int b, int c) 
        {
            int smallest = 0;
            if (a <= b && a <= c)
            {
                smallest = a;
            }
            if (b <= a && b <= c)
            {
                smallest = b;
            }
            if (c <= b && c <= a)
            {
                smallest = c;
            }
            Console.WriteLine(smallest);
        }
    }
}
