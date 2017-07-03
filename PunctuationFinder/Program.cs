using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
           var text = File.ReadAllText("sample_text.txt");

            char[] charsToRemove = new char[]
            {
                '.', ',', '!', '?',':'
            };

            File.WriteAllText("output.txt", string.Join("", text.Split(charsToRemove)));
            Console.WriteLine();
        }
    }
}
