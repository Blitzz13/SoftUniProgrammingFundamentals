using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeManipulation
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string command = tokens[0];
                if (command == "END")
                {
                    break;
                }
                if (command == "Reverse")
                {

                    Array.Reverse(arr);

                }
                else if (command == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (command == "Replace")
                {
                    try
                    {
                        int index = int.Parse(tokens[1]);
                        string word = tokens[2];
                        arr[index] = word;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}


