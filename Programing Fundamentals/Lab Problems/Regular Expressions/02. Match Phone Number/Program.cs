using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\+[359]+)([' '|'\-'])[2]\2[0-9]{3}\2[0-9]{4}\b";

            string input = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(input, regex);

            var phoneCollection = matchCollection.Cast<Match>().Select(m => m.Value.Trim()).ToArray();

            Console.Write(String.Join(", ", matchCollection));
        }
    }
}
