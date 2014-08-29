using System;
using System.IO;

namespace FirstNonRepeatedCharacter
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the First Non-Repeated Character Challenge found on
    /// https://www.codeeval.com/open_challenges/12/
    /// </summary>
    class FirstNonRepeatedCharacter
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    foreach (char c in line)
                    {
                        if (line.IndexOf(c) == line.Length - 1)
                        {
                            Console.WriteLine(c);
                        }
                        else 
                        {
                            if (line.Substring(line.IndexOf(c) + 1).Contains(c.ToString()))
                            {
                            }
                            else
                            {
                                Console.WriteLine(c);
                                break;
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
