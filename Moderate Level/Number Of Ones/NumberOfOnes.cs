using System;
using System.IO;

namespace NumberOfOnes
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Number of Ones Challenge found on
    /// https://www.codeeval.com/open_challenges/16/
    /// </summary>
    class NumberOfOnes
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    int number = Int32.Parse(sr.ReadLine());

                    Console.WriteLine(CountOfOnesInBinary(number));
                }
            }
        }

        private static int CountOfOnesInBinary(int numberToConvert)
        {
            string binaryString = Convert.ToString(numberToConvert, 2);

            int count = 0;

            foreach (char bit in binaryString)
            {
                if (bit == '1')
                    count += 1;
            }

            return count;
        }
    }
}
