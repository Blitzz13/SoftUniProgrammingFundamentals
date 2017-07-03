using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();

            int errorsCount = 0;
            while (errorsCount != 3)
            {

                string[] tokens = Console.ReadLine().Split().ToArray();
                string command = "";
                int index = 0;
                int elemntOrEndIndex = 0;

                if (tokens.Length == 2)
                {
                   
                }
                else
                {
                    elemntOrEndIndex = int.Parse(tokens[2]);
                }
                try
                {
                    command = tokens[0];
                    index = int.Parse(tokens[1]);
                    

                    command = command.ToLower();

                    if (command == "replace")
                    {
                        ints[index] = elemntOrEndIndex;
                    }
                    else if (command == "show")
                    {
                        Console.WriteLine(ints[index]);
                    }
                    else if (command == "print")
                    {
                        if (elemntOrEndIndex < 0 || elemntOrEndIndex >= ints.Count)
                        {
                            Console.WriteLine("The index does not exist!");
                            errorsCount++;
                            continue;
                        }

                        for (int i = index; i <= elemntOrEndIndex; i++)
                        {
                            if (i == elemntOrEndIndex)
                            {
                                Console.Write(ints[i]);
                                break;
                            }
                            Console.Write($"{ints[i]}, ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    errorsCount++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    errorsCount++;
                }
                
            }

            Console.WriteLine(string.Join(", ", ints));
        }
    }
}

