using System;
using System.Linq;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            if (dnaLength == 0)
            {
                return;
            }

            int[] dnaArray = new int[dnaLength];
            int[] bestDnaSample = new int[dnaLength];

            int dnaMaxSum = 0;
            int maxSequenceLength = 0;
            int minStartIndex = 0;
            int bestSample = 1;


            int dnaCount = 0;

            while (true)
            {
                int dnaSum = 0;
                int currentStartIndex = 0;
                int currentSequenceLength = 0;

                int maxLength = 0;
                int bestIndex = 0;


                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                dnaArray = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                dnaCount++;



                for (int i = 0; i < dnaLength; i++)
                {


                    if (dnaArray[i] == 1)
                    {
                        currentSequenceLength++;
                        dnaSum++;

                        if (currentSequenceLength == 1)
                        {
                            currentStartIndex = i;
                        }
                        if (currentSequenceLength > maxLength)
                        {
                            maxLength = currentSequenceLength;
                            bestIndex = currentStartIndex;
                        }
                    }
                    else
                    {
                        currentSequenceLength = 0;
                        currentStartIndex = 0;
                    }
                }
                bool isItTheBestDna = false;

                if (maxLength > maxSequenceLength)
                {
                    isItTheBestDna = true;
                }

                else if (maxLength == maxSequenceLength)
                {
                    if (currentStartIndex < minStartIndex)
                    {
                        isItTheBestDna = true;
                    }

                    else if (bestIndex == currentStartIndex)
                    {
                        if (dnaSum > dnaMaxSum)
                        {
                            isItTheBestDna = true;
                        }
                    }
                }
                if (isItTheBestDna)
                {
                    maxSequenceLength = maxLength;
                    minStartIndex = bestIndex;
                    dnaMaxSum = dnaSum;
                    bestSample = dnaCount;

                    for (int i = 0; i < dnaLength; i++)
                    {
                        bestDnaSample[i] = dnaArray[i];
                    }

                }

            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {dnaMaxSum}.");
            Console.WriteLine(string.Join(" ", bestDnaSample));

        }
    }
}
