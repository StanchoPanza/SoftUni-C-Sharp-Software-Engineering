using System;

namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTriangle(num);
        }
        static void Printline(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                Printline(1, line);
            }
            for (int line = n - 1; line >= 1; line--)
            {
                Printline(1, line);
            }

        }
    }
}
