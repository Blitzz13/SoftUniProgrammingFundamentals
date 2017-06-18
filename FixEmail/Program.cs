using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            do
            {

                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();


                dict[name] = email;

            } while (true);
            var sortedEmails = dict.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk")))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var nameEmail in sortedEmails)
            {
                var name = nameEmail.Key;
                var email = nameEmail.Value;
                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}
