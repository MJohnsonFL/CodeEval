using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace BeautifulStrings
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Beautiful Strings found on
    /// https://www.codeeval.com/open_challenges/83/
    /// </summary>
    class BeautifulStrings
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(EvaluateLine(line));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }

        public static int EvaluateLine(string line)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char character in line)
            {
                if (Char.IsLetter(character))
                {
                    char c = Char.ToLower(character);
                    if (letterCount.ContainsKey(c))
                        letterCount[c] += 1;
                    else
                        letterCount.Add(c, 1);
                }
            }

            var sortedDict = from entry in letterCount orderby entry.Value descending select entry;
            int lineValue = 0;
            int beautyWeight = 26;
            foreach (var entry in sortedDict)
            {
                lineValue += entry.Value * beautyWeight;
                beautyWeight--;
            }
            return lineValue;
        }
    }
}
