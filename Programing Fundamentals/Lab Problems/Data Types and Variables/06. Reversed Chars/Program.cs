﻿using System;

namespace _6._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            char[] chars = { c, b , a };

            Console.WriteLine(String.Join(" ", chars));
        }
    }
}
