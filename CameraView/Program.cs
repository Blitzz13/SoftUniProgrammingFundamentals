using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skiped = tokens[0];
            int taken = tokens[1];
            string text = Console.ReadLine();
            string patern = @"\|<(?<skiped>\w{"+skiped+@"})(?<taken>\w{0,"+taken+"})";
            var matches = Regex.Matches(text,patern);

            for (int i = 0; i < matches.Count; i++)
            {
                if (i == matches.Count - 1)
                {
                    Console.Write(matches[i].Groups["taken"]);
                    break;
                }
                Console.Write(matches[i].Groups["taken"] + ", ");
            }
            Console.WriteLine();

        }
    }
}
