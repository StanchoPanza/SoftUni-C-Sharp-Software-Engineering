﻿using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeOfGrade(double.Parse(Console.ReadLine()));
        }
        static void TypeOfGrade(double grade)
        {
            if (grade >= 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            if (grade >= 3 && grade < 3.5)
            {
                Console.WriteLine("Poor");
            }
            if (grade >= 3.5 && grade < 4.5)
            {
                Console.WriteLine("Good");
            }
            if (grade >= 4.5 && grade < 5.5)
            {
                Console.WriteLine("Very good");
            }
            if (grade >= 5.5 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
