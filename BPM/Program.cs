using System;

namespace BPM
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = int.Parse(Console.ReadLine());
            double numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4;
            double timeMinutes = numberOfBeats / bpm;
            double timeSeconds = timeMinutes * 60;
            
            if (timeSeconds % 60 != 0)
            {
                timeSeconds %= 60;
            }
            else
            {
                timeSeconds = 0;
            }

            Console.Write($"{Math.Round(bars,1)} bars - {(int)timeMinutes}m {(int)timeSeconds}s");
            
        }
    }
}
