namespace _05._Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] teamData = Console.ReadLine().Split("-", StringSplitOptions.TrimEntries);
                string creator = teamData[0];
                string teamName = teamData[1];

                Team newTeam = new Team(teamName, creator);

                if (Team.TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {newTeam.TeamName} was already created!");
                }
                else if (Team.CreatorAlreadyHaveATeam(teams, creator))
                {
                    Console.WriteLine($"{newTeam.Creator} cannot create another team!");
                }
                else
                {
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.Creator}!");
                }

                
            }

            string command;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] playerData = command.Split("->", StringSplitOptions.TrimEntries);
                string playerName = playerData[0];
                string teamName = playerData[1];

                if (!Team.TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (!Team.PlayerAlredyInATeam(teams, playerName))
                {
                    Console.WriteLine($"Member {playerName} cannot join team {teamName}!");
                }
                else 
                {
                    Team team = teams.FirstOrDefault(t => t.TeamName == teamName);
                    team.Members.Add(playerName);
                }
            }

            List<Team> emptyTeams = teams.Where(t => t.Members.Count == 0).ToList();


            if (teams.Members.Count > 0) 
            {
                
            }
            else if (emptyTeams.Count > 0)
            {
                foreach (Team team in teams.OrderBy(t => t.TeamName))
                {

                }
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
        }

        public  List<string> members = new List<string>();
        public string TeamName { get; private set; }
        public string Creator { get; private set; }
        public List<string> Members => members;

        public static bool TeamExists(List<Team> teams, string teamName)
        {
            return teams.Any(team => team.TeamName == teamName);
        }

        public static bool CreatorAlreadyHaveATeam(List<Team> teams, string creator)
        {
            return teams.Any(team => team.Creator == creator);
        }

        public static bool PlayerAlredyInATeam(List<Team> teams, string playerName) 
        {
            bool empty = false;
            foreach (Team team in teams)
            {
                team.members.FirstOrDefault(t => t == playerName);

                if (team.members == null)
                {
                    empty = true;
                }
            }

            return empty;
        }
    }
}