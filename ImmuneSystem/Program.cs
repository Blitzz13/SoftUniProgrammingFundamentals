using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            long maxHealth = long.Parse(Console.ReadLine());
            long curHealth = maxHealth;
            string virus = Console.ReadLine();
            List<string> viruses = new List<string>();
            //viruses.Add(virus);
            while (virus != "end")
            {

                int strenght = 0;
                int timeToDefeat = 0;
                int min = 0;
                int sec = 0;
                

                if (!viruses.Contains(virus))
                {
                    viruses.Add(virus);
                    strenght = virus.Sum(b => b);
                    strenght /= 3;
                    timeToDefeat = virus.Length * strenght;
                    Console.WriteLine($"Virus {virus}: {strenght} => {timeToDefeat} seconds");
                    curHealth -= timeToDefeat;
                    if (curHealth <= 0)
                    {
                        break;
                    }
                    min = timeToDefeat / 60;
                    sec = timeToDefeat % 60;
                    Console.WriteLine($"{virus} defeated in {min}m {sec}s.");
                    Console.WriteLine($"Remaining health: {curHealth}");
                }
                else if (viruses.Contains(virus))
                {
                    strenght = virus.Sum(b => b);
                    strenght /= 3;
                    timeToDefeat = (strenght * virus.Length) / 3;
                    Console.WriteLine($"Virus {virus}: {strenght} => {timeToDefeat} seconds");
                    curHealth -= timeToDefeat;
                    if (curHealth <= 0)
                    {
                        break;
                    }
                    min = timeToDefeat / 60;
                    sec = timeToDefeat % 60;
                    Console.WriteLine($"{virus} defeated in {min}m {sec}s.");
                    Console.WriteLine($"Remaining health: {curHealth}");
                }


                double percentToReturn = curHealth * 0.2;
                if (curHealth + percentToReturn > maxHealth)
                {
                    curHealth = maxHealth;
                }
                else
                {
                    curHealth += (long)percentToReturn;
                }

                virus = Console.ReadLine();
            }
            if (curHealth <= 0)
            {
                Console.WriteLine($"Immune System Defeated.");
            }
            else
            {
                Console.WriteLine($"Final Health: {curHealth}");
            }
        }
    }
}
