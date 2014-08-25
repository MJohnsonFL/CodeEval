using System;
using System.IO;

namespace SumOfIntegersFromFile
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Sum of Integers from File Challenge found on
    /// https://www.codeeval.com/open_challenges/24/
    /// </summary>
    class SumOfIntegersFromFile
    {
        static void Main(string[] args)
        {
            int Sum = 0;

            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        int line = Int32.Parse(sr.ReadLine());
                        Sum += line;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(Sum);
        }
    }
}
