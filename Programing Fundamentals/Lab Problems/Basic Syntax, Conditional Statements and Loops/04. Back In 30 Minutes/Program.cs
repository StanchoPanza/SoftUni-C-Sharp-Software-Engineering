using System;

namespace BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int currentMinutes = minutes + 30;

            if (currentMinutes > 59)
            {
                hours += 1;
                currentMinutes -= 60;
            }
            if (hours == 24)
            {
                hours = 00;
            }

            Console.WriteLine($"{hours}:{currentMinutes:D2}");

        }
    }
}
