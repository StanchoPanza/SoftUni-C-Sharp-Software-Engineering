using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentBook = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentBook.ContainsKey(studentName))
                {
                    studentBook.Add(studentName, new List<double>());
                    studentBook[studentName].Add(studentGrade);
                    continue;
                }
                else
                {
                    studentBook[studentName].Add(studentGrade);
                }
            }

            foreach (string studentName in studentBook.Keys)
            {
                double avarageGrade = studentBook[studentName].Average();

                if (avarageGrade >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {avarageGrade:F2}");
                }
                else
                {
                    studentBook.Remove(studentName);
                }
                
            }
        }
    }
}
