using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToArray();


            string temp = String.Join(" ", input);

            string[] result = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
