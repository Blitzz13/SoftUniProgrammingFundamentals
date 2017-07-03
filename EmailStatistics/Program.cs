using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b(?<username>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}[.](com|bg|org))\b");

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, HashSet<string>> emails = new Dictionary<string, HashSet<string>>(n);
            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();

                var match = regex.Match(email);

                string userName = match.Groups["username"].Value;
                string domain = match.Groups["domain"].Value;
                if (!(emails.ContainsKey(domain)) && match.Success)
                {
                    emails.Add(domain, new HashSet<string>());

                    emails[domain].Add(userName);
                }
                else if (emails.ContainsKey(domain) && match.Success)
                {
                    emails[domain].Add(userName);
                    continue;
                }

            }
            var orderedEmails = emails.OrderByDescending(a => a.Value.Count).ToDictionary(a => a.Key, a => a.Value);
            foreach (var email in orderedEmails)
            {
                Console.WriteLine(email.Key + ":");
                foreach (var username in email.Value)
                {
                    Console.WriteLine("### " + username);
                }
            }
        }
    }
}
