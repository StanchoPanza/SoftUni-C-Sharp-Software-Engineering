using System;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            XnXMatrix(n);
        }
        static void XnXMatrix(int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                for (int j = 1; j <= counter; j++)
                {
                    Console.Write(counter + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
