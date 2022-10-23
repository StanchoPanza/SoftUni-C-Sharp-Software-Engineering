using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grade = double.Parse(Console.ReadLine());

            int gradeCount = 1;
            double minGrade = 0;
            double avarageGrade = 0;
            double gradeSum = 0;


            while (true)
            {
                gradeSum += grade;
                avarageGrade = gradeSum / gradeCount;
                if (grade < 4.00)
                {

                    minGrade++;
                    if (minGrade == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeCount- 1} grade");
                        break;
                    }
                }
                else if (gradeCount == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:F2}");
                    break;
                }
                gradeCount++;
                grade = double.Parse(Console.ReadLine());
            }
            
        }
    }
}
