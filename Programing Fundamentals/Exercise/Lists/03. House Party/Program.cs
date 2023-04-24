using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfGuests = new List<string>();

            int guestCount = int.Parse(Console.ReadLine());



            for (int i = 0; i < guestCount; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[2] == "going!")
                {
                    IsGoing(input, listOfGuests);
                }
                else
                {
                    IsNotGoing(input, listOfGuests);
                }
            }
            foreach (string guests in listOfGuests) 
            {
                Console.WriteLine(guests);
            }
        }

        static List<string> IsGoing(List<string> input, List<string> output)
        {
            if (output.Contains(input[0]))
            {
                Console.WriteLine($"{input[0]} is already in the list!");
                return output;
            }
            else
            {
                output.Add(input[0]);
                return output;
            }
        }
        static List<string> IsNotGoing(List<string> input, List<string> output)
        {
            if (output.Contains(input[0]))
            {
                output.Remove(input[0]);
                return output;
            }
            else
            {
                Console.WriteLine($"{input[0]} is not in the list!");
                return output;
            }
        }
    }
}
