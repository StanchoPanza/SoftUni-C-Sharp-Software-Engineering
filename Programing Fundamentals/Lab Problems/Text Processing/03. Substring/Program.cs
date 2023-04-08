using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string initString = Console.ReadLine();


            while (true)
            {
                if (initString.Contains(toRemove))
                {
                    int startIndex = initString.IndexOf(toRemove);

                    initString = initString.Remove(startIndex, toRemove.Length);
                }

                else
                {
                    break;
                }
            }
            Console.WriteLine(initString);
        }
    }
}
