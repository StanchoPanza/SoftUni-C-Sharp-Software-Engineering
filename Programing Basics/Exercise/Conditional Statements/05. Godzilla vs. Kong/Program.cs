using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double shootingTime = double.Parse(Console.ReadLine());
            double scenesCount = double.Parse(Console.ReadLine());
            double timePerScene = double.Parse(Console.ReadLine());

            double fieldPreparationTime = shootingTime * 0.15;

            double SceneShootingTime = scenesCount * timePerScene;

            double totalShootingTime = SceneShootingTime + fieldPreparationTime;

            double timeLeft = Math.Abs(shootingTime - totalShootingTime);

            if (totalShootingTime <= shootingTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeLeft)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeLeft)} minutes.");
            }
        }
    }
}
