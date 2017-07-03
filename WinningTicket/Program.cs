using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex ticketsMatchPatern = new Regex(@"([@#$^\w*]{10})");
            Regex charsMatchPatern = new Regex(@"[@#$^]+");
            Regex splitPatern = new Regex(@"[, ]+");
            string[] tickets = splitPatern.Split(Console.ReadLine());
            string allTickets = string.Join(", ", tickets);
            var validTickets = ticketsMatchPatern.Matches(allTickets);
            int longestCharCount = 0;
            int charCount = 0;
            for (int i = 0; i < tickets.Length; i++)
            {
                    for (int a = 0; a < validTickets.Count; a++)
                    {
                if (ticketsMatchPatern.Match(tickets[i]).Success)
                {
                        MatchCollection thisTicket = charsMatchPatern.Matches(validTickets[a].Value);
                        for (int j = 0; j < thisTicket.Count; j++)
                        {
                            charCount = thisTicket[j].Groups[0].Length;
                            if (charCount > longestCharCount)
                            {
                                longestCharCount = charCount;
                            }
                        }
                        
                        longestCharCount = 0;
                    
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
           
        }
    }
}
    }
