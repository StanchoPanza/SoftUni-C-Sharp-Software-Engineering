using System;

namespace SwimmingWorldRecored
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay *= 12.5;
            double timeIvan = distance * speed + delay;



            if (timeIvan < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeIvan - record:F2} seconds slower.");
            }
        }
    }
}
