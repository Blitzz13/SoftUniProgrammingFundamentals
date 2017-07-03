using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunctuationFinderr
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt");

            var textCharArr = text.ToCharArray();
            List<char> chars = new List<char>();
            for (int i = 0; i < textCharArr.Length; i++)
            {
                if (textCharArr[i] == '.' || textCharArr[i] == ',' || textCharArr[i] == '!' || textCharArr[i] == '?' || textCharArr[i] == ':')
                {
                    chars.Add(textCharArr[i]);
                }
            }

            Console.WriteLine(string.Join(", ",chars));
        }
    }
}
