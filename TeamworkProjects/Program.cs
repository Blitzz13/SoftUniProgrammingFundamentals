using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            List<string> creators = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();

                string creatorName = tokens.First();
                string teamName = tokens[1];

                if (teams.Select(a => a.TeamName).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (creators.Contains(creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    Team team = new Team()
                    {
                        CreatorName = creatorName,
                        TeamName = teamName,
                        Members = new List<string>()
                    };

                    teams.Add(team);
                    creators.Add(creatorName);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }
            List<string> members = new List<string>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split('-', '>').ToArray();

                string breakingPoint = string.Join(" ", tokens);
                if (breakingPoint == "end of assignment")
                {
                    break;
                }

                string user = tokens[0];
                string team = tokens[2];

                if (teams.Select(a => a.TeamName).Contains(team))
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        
                        if (creators.Contains(user) || members.Contains(user))
                        {
                            Console.WriteLine($"Member {user} cannot join team {team}!");
                            break;
                        }
                        else if(teams[i].TeamName == team)
                        {
                            teams[i].Members.Add(user);
                            members.Add(user);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
            }
            List<string> teamsToDisban = new List<string>();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count == 0)
                {
                    teamsToDisban.Add(teams[i].TeamName);
                    teams.Remove(teams[i]);
                    i--;
                }
            }
          
            teams = teams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName).ToList();
            
            for (int i = 0; i < teams.Count; i++)
            {
                teams[i].Members.Sort();
            }
            
            foreach (var team in teams)
            {

                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            
            teamsToDisban.Sort();
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisban)
            {
                Console.WriteLine($"{team}");
            }
        }
    }

    class Team
    {
        public string CreatorName { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}
