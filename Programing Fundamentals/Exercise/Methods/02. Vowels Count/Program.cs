using System;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            VowelsCount(input);

        }
        static void VowelsCount(string input) 
        {
            int vowelsCount = 0;
            input = input.ToLower();

            char[] vowels = new char[5]
                {'a', 'e', 'u', 'i', 'o' };

            for (int i = 0; i < vowels.Length; i++) 
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (vowels[i] == input[j])
                    {
                        vowelsCount++;
                    }
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
