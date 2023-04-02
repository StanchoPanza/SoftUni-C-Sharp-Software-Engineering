using System;

namespace RefactorVolumeofPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 0;

            double widht = 0;

            double heigth  = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            widht = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            double baseArea = length * widht;
            double result = (baseArea * heigth) / 3;
            Console.Write($"Pyramid Volume: {result:f2}");

        }
    }
}
