using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();

                string name = tokens[0];
                string id = tokens[1];
                long age = long.Parse(tokens[2]);

                User user = new User()
                {
                    Name = name,
                    Age = age,
                    Id = id
                };
                users.Add(user);
            }

            users = users.OrderBy(a => a.Age).ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} with ID: {user.Id} is {user.Age} years old.");
            }
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public long Age { get; set; }
    }
}
