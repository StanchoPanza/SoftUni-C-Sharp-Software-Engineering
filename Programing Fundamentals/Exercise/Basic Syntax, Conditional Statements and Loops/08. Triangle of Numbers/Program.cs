using System;

namespace TriangleofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int r = 1; r <= num; r++)
            {
                for (int i = 0; i < r; i++)
                {
                    Console.Write(r + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
