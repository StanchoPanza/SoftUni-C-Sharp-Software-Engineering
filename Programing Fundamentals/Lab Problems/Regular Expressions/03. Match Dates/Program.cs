using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<date>[0-9]{2})([/|./-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                var date = match.Groups["date"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }

        }
    }
}
