using System;
using System.IO;

namespace Lowercase
{
    class Lowercase
    {
        /// <summary>
        /// Program written by Michael P. Johnson
        /// for the Lowercase Challenge found on
        /// https://www.codeeval.com/open_challenges/20/
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine().ToLower());
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
