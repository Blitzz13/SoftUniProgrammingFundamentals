using System;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string command = tokens[0];
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
                    int index = int.Parse(tokens[1]);
                    string word = tokens[2];
                    arr[index] = word;
                }
            }

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
