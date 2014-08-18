using System;
using System.IO;

namespace RollerCoaster
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Roller Coaster Challenge found on
    /// https://www.codeeval.com/open_challenges/156/
    /// </summary>
    class RollerCoaster
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
                        Console.WriteLine(line.RollerCoastText());
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

    static class ExtensionMethods
    {
        public static string RollerCoastText(this string sentence)
        {
            string returnSentence = "";
            int letterCount = 0;

            foreach(char character in sentence)
            {
                if (Char.IsLetter(character))
                {
                    letterCount++;
                    if (letterCount % 2 == 0)
                        returnSentence += Char.ToLower(character);
                    else
                        returnSentence += Char.ToUpper(character);
                }
                else
                    returnSentence += character;
            }
            return returnSentence;
        }
    }
}
