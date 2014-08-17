using System;
using System.IO;

namespace FizzBuzz
{   
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Fizz Buzz Challenge found on
    /// https://www.codeeval.com/open_challenges/1/
    /// </summary>
    class FizzBuzz
    {
        public static string FizzBuzzSet(int A, int B, int N)
        {
            string returnString = string.Empty;

            for (int i = 1; i <= N; i++)
            {
                string output = string.Empty;

                if (i % A == 0)
                    output = "F";
                if (i % B == 0)
                    output += "B";
                if (output == string.Empty)
                    output = i.ToString();
                if (i != N)
                    output += " ";
                returnString += output;
            }

            return returnString;

        }

        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        Console.WriteLine(FizzBuzzSet(Int32.Parse(line[0]), Int32.Parse(line[1]), Int32.Parse(line[2])));
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
