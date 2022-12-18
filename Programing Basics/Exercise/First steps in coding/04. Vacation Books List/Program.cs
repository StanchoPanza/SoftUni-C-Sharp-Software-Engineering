using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            double totalHours = (numberOfPages / pagesPerHour);
            double totalDays = (totalHours / numberOfDays);
            Console.WriteLine(totalDays);


        }
    }
}
