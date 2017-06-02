using System;
using System.Numerics;
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

            BigInteger minutes = hours * 60;
            BigInteger seconds = (BigInteger)(minutes * 60);
            BigInteger miliSeconds = (seconds * 1000);
            BigInteger mircroSeconds = (miliSeconds * 1000);
            BigInteger nanoSeconds = (mircroSeconds * 1000);

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {mircroSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }
}
