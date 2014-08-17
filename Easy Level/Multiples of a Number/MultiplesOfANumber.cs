using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MultiplesOfANumber
{
    class MultiplesOfANumber
    {
        /// Program written by Michael P. Johnson
        /// for the Multiples of a Number Challenge found on
        /// https://www.codeeval.com/open_challenges/18/
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
                        Console.WriteLine(SmallestMultiple(Int32.Parse(line[0]), Int32.Parse(line[1])));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }

        public static int SmallestMultiple(int x, int n)
        {
            int nOriginal = n;
            while (n <= x)
            {
                n += nOriginal;
            }
            return n;
        }
    }
}
