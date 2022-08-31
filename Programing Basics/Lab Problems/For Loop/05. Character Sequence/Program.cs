using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            for (int i = 0; i < a.Length; i++)
            {
                char letter = a[i];
                Console.WriteLine(letter);
            }
        }
    }
}
