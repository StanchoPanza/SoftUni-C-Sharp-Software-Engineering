using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderbyAge
{
    public class Person

    {
        public Person(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " with ID: " + Id + " is " + Age + " years old."; 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> allPersons = new List<Person>();

            while (input != "End")
            {
                string[] personData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personData[0];
                int id = int.Parse(personData[1]);
                int age = int.Parse(personData[2]);

                Person newPerson = new Person(name, id, age);

                if (allPersons.Any(x => x.Id == id))
                {
                    var personToUpdate = allPersons.FirstOrDefault(x => x.Id == id);
                    personToUpdate.Age = age;
                    personToUpdate.Name = name;
                }
                else
                {
                    allPersons.Add(newPerson);
                }
                input = Console.ReadLine();
            }
            

            foreach (Person person in allPersons.OrderBy(x=>x.Age))
            {
                Console.WriteLine(person);
            }


        }
    }
}
