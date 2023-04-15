using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = int.Parse(Console.ReadLine());

            if (fieldLength < 0)
            {
                return;
            }

            int[] field = new int[fieldLength];

            int[] ladybugStartIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (int i in ladybugStartIndexes)
            {
                if (i > field.Length - 1 || i < 0)
                {
                    continue;
                }
                field[i] = 1;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();


                int indexOfLady = int.Parse((string)command[0]);
                string direction = command[1];
                int steps = int.Parse((string)command[2]);

                bool notMoved = true;

                if (direction == "left" && steps < 0)
                {
                    direction = "right";
                    steps = Math.Abs(steps);
                }
                else if (direction == "right" && steps < 0)
                {
                    direction = "left";
                    steps = Math.Abs(steps);
                }
                if (indexOfLady < 0 || indexOfLady > field.Length - 1 || steps == 0)
                {
                    continue;
                }
                if (field[indexOfLady] == 0)
                {
                    continue;
                }

                field[indexOfLady] = 0;

                if (direction == "left")
                {

                    while (notMoved)
                    {
                        if (indexOfLady - steps < 0)
                        {
                            break;
                        }
                        if (field[indexOfLady - steps] == 0)
                        {
                            field[indexOfLady - steps] = 1;
                            notMoved = false;
                        }
                        else
                        {
                            indexOfLady -= steps;
                        }

                    }
                }

                if (direction == "right")
                {

                    while (notMoved)
                    {

                        if (indexOfLady + steps > field.Length - 1)
                        {
                            break;
                        }
                        if (field[indexOfLady + steps] == 0)
                        {
                            field[indexOfLady + steps] = 1;
                            notMoved = false;
                        }
                        else
                        {
                            indexOfLady += steps;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
