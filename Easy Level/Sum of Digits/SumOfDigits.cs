using System;
using System.IO;

namespace SumOfDigits
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Sum of Digits Challenge found on
    /// https://www.codeeval.com/open_challenges/21/
    /// </summary>
    class SumOfDigits
    {
        public static int SumTheDigits(string line)
        {
            int sum = 0;

            foreach (char c in line)
                sum += Int32.Parse(c.ToString());

            return sum;
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
                        Console.WriteLine(SumTheDigits(line));
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
