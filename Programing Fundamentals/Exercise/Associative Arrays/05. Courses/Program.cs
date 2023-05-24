using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> courseTracker= new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] newstudent = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = newstudent[0];
                string studentName = newstudent[1];

                if (courseTracker.ContainsKey(courseName))
                {
                    courseTracker[courseName].Add(studentName);
                }
                else
                {
                    courseTracker.Add(courseName, new List<string>());
                    courseTracker[courseName].Add(studentName);
                }
                input = Console.ReadLine();
            }
            foreach (var kvp in courseTracker)
            {
                int studentsCount = kvp.Value.Count();
                Console.WriteLine($"{kvp.Key}: {studentsCount}");
                Console.WriteLine($"-- {string.Join("\n-- ", kvp.Value)}");
            }
        }
    }
}
