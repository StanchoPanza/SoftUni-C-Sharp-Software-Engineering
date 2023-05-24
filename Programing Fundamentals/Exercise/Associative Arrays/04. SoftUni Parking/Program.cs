using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> allUsers = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] newUser = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = newUser[0];

                if (command == "register")
                {

                    string username = newUser[1];
                    string licensePlate = newUser[2];

                    if (allUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        allUsers.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }
                if (command == "unregister")
                {
                    string username = newUser[1];
                    if (allUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        allUsers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var user in allUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
                
        }
    }
}
