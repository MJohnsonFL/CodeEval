using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LongestLines
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Longest Lines Challenge found on
    /// https://www.codeeval.com/open_challenges/2/
    /// </summary>
    class LongestLines
    {
        static void Main(string[] args)
        {
            int NumberOfLines;
            List<string> ListOfStrings = new List<string>();

            using (StreamReader sr = new StreamReader(args[0]))
            {
                NumberOfLines = Int32.Parse(sr.ReadLine());

                while (!sr.EndOfStream)
                {
                    ListOfStrings.Add(sr.ReadLine());
                }
            }

            var sorted = from line in ListOfStrings orderby line.Length descending select line;
            for (int i = 0; i < NumberOfLines; i++)
                Console.WriteLine(sorted.ElementAt(i));
        }
    }
}
