using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string time = Console.ReadLine();
            //    int steps = int.Parse(Console.ReadLine());
            //    int timeInSecsForStep = int.Parse(Console.ReadLine());

            //    string[] tokens = time.Split(':').ToArray();

            //    int currentHours = int.Parse(tokens.First());
            //    int currentMins = int.Parse(tokens[1]);
            //    int currentSecs = int.Parse(tokens.Last());

            //    int secondsToHome = steps * timeInSecsForStep;
            //    int newMins = 0;
            //    int newHours = 0;
            //    int newSeconds = (currentSecs + secondsToHome);
            //    int rem = 0;
            //    if (newSeconds >= 60)
            //    {
            //        rem = newSeconds % 60;
            //        newSeconds /= 60;
            //        newMins += newSeconds;
            //        newSeconds = rem;
            //    }
            //    newMins += currentMins;
            //    if (newMins >= 60)
            //    {
            //        rem = newMins % 60; 
            //        newMins /= 60;
            //        newHours += newMins;
            //        newMins = rem;
            //    }
            //    newHours += currentHours;
            //    if (newHours > 23)
            //    {
            //        newHours -= 24;
            //    }
            //    Console.WriteLine($"Time Arrival: {newHours:d2}:{newMins:d2}:{newSeconds:d2}");

            string format = "HH:mm:ss";
            DateTime time = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

            int steps = int.Parse(Console.ReadLine());
            int timeInSecsForStep = int.Parse(Console.ReadLine());

            long newSeconds = steps * timeInSecsForStep;

            time = time.AddSeconds(newSeconds);
            Console.WriteLine($"Time Arrival: {time.TimeOfDay}");


        }
    }
}
