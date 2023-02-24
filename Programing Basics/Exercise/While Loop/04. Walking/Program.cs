using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {


            int totalSteps = 0;
            int stepsToHome = 0;

            while (totalSteps < 10000)
            {
                string steps = Console.ReadLine();
                
                if (steps == "Going home")
                {
                    stepsToHome = int.Parse(Console.ReadLine());
                    break;
                }

                int input = int.Parse(steps);
                totalSteps += input;

                if (totalSteps >= 10000)
                {
                    break;
                }
            }

            if (totalSteps + stepsToHome >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!\n{totalSteps + stepsToHome - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps - stepsToHome} more steps to reach goal.");
            }

        }
    }
}
