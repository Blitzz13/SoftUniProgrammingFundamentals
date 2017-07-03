using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] partisipants = Console.ReadLine().Split();
            Regex regex = new Regex(@",[ ]{1,}");
            string songsLine = Console.ReadLine();
            for (int i = 0; i < partisipants.Length; i++)
            {
                if (partisipants[i].Contains(","))
                {
                    partisipants[i] = partisipants[i].Remove(partisipants[i].Length - 1);
                }
            }
            string[] songs = Regex.Split(songsLine, @",[ ]{1,}");
           
            string[] line = Regex.Split(Console.ReadLine(), @",[ ]{1,}");

            Dictionary<string, HashSet<string>> people = new Dictionary<string, HashSet<string>>();
            string song = "";
            string award = "";
            while (line.First() != "dawn")
            {
                string participant = line.First();
                if (partisipants.Contains(participant))
                {
                    song = line[1];
                    award = line.Last();
                }
                
                if ((partisipants.Contains(participant) && songs.Contains(song)) && !(people.ContainsKey(participant)) && award != song)
                {
                    people.Add(participant, new HashSet<string>());
                }
                if (people.ContainsKey(participant) && songs.Contains(song))
                {
                    people[participant].Add(award);
                }
                line = Regex.Split(Console.ReadLine(), @",[ ]{1,}");
            }

            if (people.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var person in people.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"{person.Key}: {person.Value.Count} awards");
                    foreach (var awards in person.Value.OrderBy(a => a))
                    {
                        Console.WriteLine("--" + awards);
                    }
                }


            }
        }
    }
}
