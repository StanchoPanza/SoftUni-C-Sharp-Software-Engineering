using System;

namespace ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            string laguage = String.Empty;

            if (country == "England" || country == "USA")
            {
                laguage = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                laguage = "Spanish";
            }
            else
            {
                laguage = "unknown";
            }
            Console.WriteLine(laguage);
        }
    }
}
