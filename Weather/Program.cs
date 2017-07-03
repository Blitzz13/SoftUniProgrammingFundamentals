using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>[0-9]+\.[0-9]+)(?<weather>[A-Za-z]+)\|");
            Dictionary<string, WeatherInfo> cities = new Dictionary<string, WeatherInfo>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                Match weatherMatch = regex.Match(input);
                if (!weatherMatch.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string city = weatherMatch.Groups["city"].Value;
                double temp = double.Parse(weatherMatch.Groups["temp"].Value);
                string weather = weatherMatch.Groups["weather"].Value;

                WeatherInfo weatherInfo = new WeatherInfo
                {
                    Temp = temp,
                    Weather = weather
                };

                cities[city] = weatherInfo;
                input = Console.ReadLine();
            }
            var orderedCities = cities.OrderBy(a => a.Value.Temp).ToDictionary(a => a.Key, a => a.Value);
            foreach (var city in orderedCities)
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temp:F2} => {city.Value.Weather}");
            }
        }
    }

    class WeatherInfo
    {
        public double Temp { get; set; }
        public string Weather { get; set; }
    }
}
