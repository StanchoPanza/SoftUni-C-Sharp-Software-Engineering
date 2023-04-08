using System;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string textToCheck = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string asterisks = new string('*', bannedWords[i].Length);

                textToCheck = textToCheck.Replace(bannedWords[i], asterisks);
            }
            Console.WriteLine(textToCheck);
        }
    }
}
