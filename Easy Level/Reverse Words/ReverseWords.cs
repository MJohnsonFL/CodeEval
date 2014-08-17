using System;
using System.IO;

namespace ReverseWords
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Reverse Words Challenge found on
    /// https://www.codeeval.com/open_challenges/8/
    /// </summary>
    class ReverseWords
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string sentence = sr.ReadLine();
                        if (!string.IsNullOrEmpty(sentence))
                        {
                            Console.WriteLine(ReverseSentence(sentence));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }

        public static string ReverseSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words).Trim();
        }
    }
}
