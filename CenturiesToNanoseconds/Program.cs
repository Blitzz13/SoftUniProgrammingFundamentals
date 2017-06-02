using System;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int years = century * 100;

            int days = (int)(years * 365.2422);

            int hours = days * 24;

            int minutes = hours * 60;

            uint seconds = (uint)(minutes * 60);
            ulong miliSeconds = (seconds * 1000);
            ulong mircroSeconds = (miliSeconds * 1000);
            ulong nanoSeconds = (mircroSeconds * 1000);

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} miliSeconds = {mircroSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }
}
