using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            string command;
            string phoneNumber = null;
            string name = null;
            do
            {

                var tokens = Console.ReadLine().Split(' ').ToList();
                command = tokens[0];
                if (tokens.Count == 2)
                {
                    name = tokens[1];
                }
                if (tokens.Count == 3)
                {
                    name = tokens[1];
                    phoneNumber = tokens[2];
                }
                if (command == "A")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = phoneNumber;
                    }
                    else
                    {
                        phoneBook.Add(name, phoneNumber);
                    }
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        string number;
                        phoneBook.TryGetValue(name, out number);
                        Console.WriteLine($"{name} -> {number}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    tokens.Clear();
                }
                else if (command == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            } while (command != "END");
        }
    }
}
