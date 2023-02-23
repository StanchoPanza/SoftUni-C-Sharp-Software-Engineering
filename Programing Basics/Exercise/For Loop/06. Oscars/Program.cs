using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judgeCount = int.Parse(Console.ReadLine());

            string judgeName = "";
            double judgePoints = 0;
            double totalPoints = 0;



            for (int i = 0; i < judgeCount; i++)
            {
                judgeName = Console.ReadLine();
                judgePoints = double.Parse(Console.ReadLine());

                totalPoints += ((judgeName.Length * judgePoints) / 2);

                if (totalPoints + points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {totalPoints + points:F1}!");
                    break;
                }

            }
            if (totalPoints + points <= 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.50 - totalPoints - points:F1} more!");
            }
            
        }
    }
}
