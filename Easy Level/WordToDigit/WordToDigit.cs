using System;
using System.IO;

namespace WordToDigit
{


    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Word To Digit Challenge found on
    /// https://www.codeeval.com/open_challenges/104/
    /// </summary>
    class WordToDigit
    {
        public static string ChangeWordToDigit(string[] line)
        {
            string returnString = string.Empty;

            foreach (string s in line)
            {
                if (s == "zero")
                    returnString += "0";
                else if (s == "one")
                    returnString += "1";
                else if (s == "two")
                    returnString += "2";
                else if (s == "three")
                    returnString += "3";
                else if (s == "four")
                    returnString += "4";
                else if (s == "five")
                    returnString += "5";
                else if (s == "six")
                    returnString += "6";
                else if (s == "seven")
                    returnString += "7";
                else if (s == "eight")
                    returnString += "8";
                else if (s == "nine")
                    returnString += "9";
            }

            return returnString;
        }
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        Console.WriteLine(ChangeWordToDigit(line));
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
