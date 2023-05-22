using System;
using System.Collections.Generic;

namespace Students
{
    class Students
    {

        public Students(string 
            firtsName, 
            string lastName, 
            int age, string 
            homeTown)
        {
            this.FirstName = firtsName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Students> students = new List<Students>();

            while (input != "end") 
            {
                string[] newStudent = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = newStudent[0];
                string lastName = newStudent[1];
                int age = int.Parse(newStudent[2]);
                string homeTown = newStudent[3];

                Students student = new Students(firstName, lastName, age, homeTown);
               
                students.Add(student);
                input = Console.ReadLine();
            }
            string city = Console.ReadLine();
            List<Students> filteredList = students.FindAll(students => students.HomeTown == city);

            foreach (Students student in filteredList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}
