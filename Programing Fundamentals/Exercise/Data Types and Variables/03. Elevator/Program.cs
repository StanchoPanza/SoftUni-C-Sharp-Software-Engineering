using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoplesCount = int.Parse(Console.ReadLine());
            int elevatorCap = int.Parse(Console.ReadLine());

            int courses = 0;

            while (peoplesCount > 0)
            {
                peoplesCount -= elevatorCap;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
