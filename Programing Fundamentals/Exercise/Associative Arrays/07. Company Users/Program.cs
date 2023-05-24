using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfEmployees = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] newValue = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = newValue[0];
                string employeeId = newValue[1];

                if (!listOfEmployees.ContainsKey(companyName))
                {
                    listOfEmployees.Add(companyName, new List<string>());
                    listOfEmployees[companyName].Add(employeeId);
                }
                else if (listOfEmployees[companyName].Contains(employeeId))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    listOfEmployees[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var key in listOfEmployees.Keys)
            {
                Console.WriteLine(key);

                foreach (var value in listOfEmployees[key])
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
