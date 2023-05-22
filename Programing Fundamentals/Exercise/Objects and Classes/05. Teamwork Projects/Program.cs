using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWorkProject
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;

            CreatorName = creatorName;

            Members = new List<string>();

        }

        public string TeamName { get; set; }

        public string CreatorName { get; set; }
        public List<string> Members { get; set; }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teamsList = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamInput = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorName = teamInput[0];
                string teamName = teamInput[1];


                if (teamsList.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teamsList.Any(x => x.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team team = new Team(teamName, creatorName);
                teamsList.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] operation = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string playerName = operation[0];
                string teamName = operation[1];

                if (!teamsList.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }
                if (teamsList.Any(x => x.Members.Contains(playerName)) || teamsList.Any(x => x.CreatorName.Contains(playerName)))
                {
                    Console.WriteLine($"Member {playerName} cannot join team {teamName}!");
                    input = Console.ReadLine();
                    continue;
                }
                int teamIndex = teamsList.FindIndex(x => x.TeamName == teamName);
                teamsList[teamIndex].Members.Add(playerName);

                input = Console.ReadLine();
            }
            List<Team> validTeams = teamsList.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();

            List<Team> invalidTeams = teamsList.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.TeamName);
            }

        }
    }
}
