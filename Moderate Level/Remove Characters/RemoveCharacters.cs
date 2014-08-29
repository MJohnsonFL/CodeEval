using System;
using System.IO;

namespace RemoveCharacters
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Remove Characters Challenge found on
    /// https://www.codeeval.com/open_challenges/13/
    /// </summary>
    class RemoveCharacters
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    Console.WriteLine(ScrubLine(line[0], line[1].Trim()));
                }
            }
        }

        private static string ScrubLine(string line, string scrubbingLetters)
        {
            string returnString = string.Empty;

            foreach (char c in line)
            {
                if (scrubbingLetters.Contains(c.ToString()))
                {

                }
                else
                {
                    returnString += c;
                }
            }

            return returnString;
        }
    }
}
