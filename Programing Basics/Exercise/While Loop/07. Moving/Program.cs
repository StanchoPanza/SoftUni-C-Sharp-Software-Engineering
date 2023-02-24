using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int legth = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int volume = width * legth * hight;

            

            while (volume > 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }
                int boxes = int.Parse(input);
                volume -= boxes;
            }
            if (volume > 0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
