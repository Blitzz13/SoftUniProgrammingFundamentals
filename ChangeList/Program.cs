using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = "";

            do
            {
                var tokens = Console.ReadLine().Split();
                command = tokens[0];
                if (command == "Odd" || command == "Even")
                {
                    break;
                }
                if (command == "Delete")
                {
                    string place = tokens[1];
                    list.RemoveAll(item => item == int.Parse(place));
                }
                else if (command == "Insert")
                {
                    string num = tokens[1];
                    string position = tokens[2];
                    list.Insert(int.Parse(position), int.Parse(num));

                }

            } while (true);

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] % 2 == 0 && command == "Even")
                {
                    Console.Write($"{list[i]} ");
                }
                else if (list[i] % 2 != 0 && command == "Odd")
                {
                    Console.Write($"{list[i]} ");

                }
           
            }


        }
    }
}
