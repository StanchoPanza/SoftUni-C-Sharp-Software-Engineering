using System;
using System.Text;

namespace DigitsLettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = "";
            string letters = "";

            StringBuilder leftovers = new StringBuilder();

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    digits += c;
                }
                else if (Char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    leftovers.Append(c);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(leftovers);
        }
    }
}
