using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource;
            var dict = new Dictionary<string, long>();
            do
            {
                
                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else
                {
                    dict[resource] = quantity;
                }

               
            } while (resource != "stop");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
