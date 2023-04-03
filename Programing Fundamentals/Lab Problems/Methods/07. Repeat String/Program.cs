using System;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            RepeatString(input, num);
        }
        static void RepeatString(string input, int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Console.Write(input);
            }
        }
    }
}
