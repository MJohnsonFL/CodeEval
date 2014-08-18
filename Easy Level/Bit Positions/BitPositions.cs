using System;
using System.IO;

namespace BitPositions
{
    class BitPositions
    {
        /// <summary>
        /// Program written by Michael P. Johnson
        /// for the Bit Positions Challenge found on
        /// https://www.codeeval.com/open_challenges/19/
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        Console.WriteLine(CompareBits(Int32.Parse(line[0]), Int32.Parse(line[1]), Int32.Parse(line[2])));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }

        public static string CompareBits(int number, int p1, int p2)
        {
            string binaryString = Convert.ToString(number, 2);
            if (binaryString[binaryString.Length - p1] == binaryString[binaryString.Length - p2])
                return "true";
            return "false";
        }
    }
}
