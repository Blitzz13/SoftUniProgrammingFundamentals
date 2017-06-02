using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = ((hours * 60) * 60) + minutes * 60 + seconds;
            float speed = distanceMeters / timeInSeconds;
            Console.WriteLine(speed);
            speed = 0;
            float timeInHours = seconds / 3600 + minutes / 60 + hours;
            speed = (distanceMeters / 1000) / timeInHours;
            Console.WriteLine(speed);
            float mph = speed / 1.609f;
            Console.WriteLine(mph);
        }
    }
}
