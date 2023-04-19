using System;

namespace CharactersinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            CharactersinRange(one, two);


        }
        static void CharactersinRange(char a, char b)
        {
            if (a < b)
            {
                for (int i = a; i < b - 1; i++)
                {
                    a++;
                    Console.Write(a + " ");

                }
            }
            else
            {
                for (int i = b; i < a - 1; i++)
                {
                    b++;
                    Console.Write(b + " ");

                }
            }
            
        }
    }
}
