using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgeCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double gradeSumPresentation = 0;

            int gradecount = 0;

            double avarageGrade = 0;

            double gradeTotalSum = 0;


            while (presentationName != "Finish")
            {
                gradeSumPresentation = 0;

                for (int i = 1; i <= judgeCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSumPresentation += grade;
                    gradecount++;
                    gradeTotalSum += grade;
                }
                avarageGrade = gradeSumPresentation / judgeCount;

                Console.WriteLine($"{presentationName} - {avarageGrade:f2}.");

                presentationName = Console.ReadLine();


            }
            Console.WriteLine($"Student's final assessment is {gradeTotalSum / gradecount:f2}.");

        }
    }
}
