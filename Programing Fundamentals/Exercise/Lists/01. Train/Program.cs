using System;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int passangersCount = int.Parse(Console.ReadLine());
                arr[i] = passangersCount;
                sum += passangersCount;
            }
            Console.WriteLine(string.Join(' ', arr));
            Console.WriteLine(sum);
        }
    }
}
