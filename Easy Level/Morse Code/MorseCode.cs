using System;
using System.IO;
using System.Collections.Generic;

namespace MorseCode
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Morse Code Challenge found on
    /// https://www.codeeval.com/open_challenges/116/
    /// </summary>
    class MorseCode
    {
        public static Dictionary<string, char> MorseChart = new Dictionary<string, char>()
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
            {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
            {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
            {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
            {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
            {"--..", 'Z'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'}, {"....-", '4'},
            {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'}, {"----.", '9'},
            {"-----", '0'}
        };

        public static string ConvertFromMorse(string line)
        {
            string returnString = string.Empty;
            string MorseCharString = string.Empty;
            bool AtEndOfChar = false;
            foreach (char c in line)
            {
                if (Char.IsWhiteSpace(c))
                {
                    if (AtEndOfChar)
                    {
                        returnString += " ";
                    }
                    else
                    {
                        returnString += MorseChart[MorseCharString];
                        MorseCharString = string.Empty;
                        AtEndOfChar = true;
                    }
                }
                else
                {
                    MorseCharString += c;
                    AtEndOfChar = false;
                } 
            }
            returnString += MorseChart[MorseCharString];

            return returnString;
        }

        public static char LookupMorse(string CodedString)
        {
            return ' ';
        }

        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(ConvertFromMorse(line));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
