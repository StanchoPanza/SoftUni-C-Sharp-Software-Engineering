using System;

namespace FavoriteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string favoriteBook = Console.ReadLine();
                int counter = 0;
                string nextBookName = Console.ReadLine();

                while (nextBookName != "No More Books")
                {
                    if (nextBookName == favoriteBook)
                    {
                        break;
                    }
                    counter++;
                    nextBookName = Console.ReadLine();
                }
                if (nextBookName == favoriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                }
                else
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }
            }
        }
    }
}