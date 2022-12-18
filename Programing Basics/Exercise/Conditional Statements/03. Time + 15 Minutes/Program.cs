using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes < 45)
            {
                minutes += 15;
            }
            else if (minutes >= 45 && hours !=23)
            {
                hours += 1;
                minutes = minutes + 15 - 60;
            }
            else if (minutes >= 45 && hours == 23)
            {
                minutes = minutes + 15 - 60;
                hours = 00;
            }
            {
                Console.WriteLine($"{hours}:{minutes:D2}"); 

            }
        }   
    }
}
