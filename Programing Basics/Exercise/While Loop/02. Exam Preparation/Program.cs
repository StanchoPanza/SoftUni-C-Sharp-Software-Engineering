using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());

            int lowGradeCount = 0;
            int highGradeCount = 0;
            double gradeSum = 0;
            string lastTask = "";
            bool failed = true;


            while (lowGradeCount < poorGrades)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    failed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    lowGradeCount++;
                }
                gradeSum += grade;
                highGradeCount++;
                lastTask = taskName;

            }
            if (failed)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / highGradeCount:F2}");
                Console.WriteLine($"Number of problems: {highGradeCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}
