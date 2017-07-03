using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                 "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random randGen = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int phrase = randGen.Next(0, phrases.Length);
                int hapening = randGen.Next(0, events.Length);
                int author = randGen.Next(0, authors.Length);
                int city = randGen.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrase]} {events[hapening]} {authors[author]} – {cities[city]}.");
            }
        }
    }
}
