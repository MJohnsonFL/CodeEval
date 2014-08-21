using System;
using System.IO;

namespace JugglingWithZeros
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Juggling with Zeros Challenge found on
    /// https://www.codeeval.com/open_challenges/149/
    /// </summary>
    class JugglingWithZeros
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
                        Console.WriteLine(ConvertZeroBase(line));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }


        public static int ConvertZeroBase(string line)
        {
            string[] lineSplit = line.Split(' ');
            string binaryString = "";
            for (int i = 0; i < lineSplit.Length; i += 2)
            {
                if (lineSplit[i] == "0")
                {
                    binaryString += lineSplit[i + 1];
                }
                else
                {
                    binaryString += new String('1', lineSplit[i + 1].Length);
                }
            }

            return Convert.ToInt32(binaryString, 2);
        }
    }
}
