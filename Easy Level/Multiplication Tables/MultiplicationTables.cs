using System;
using System.Text;

namespace MultiplicationTables
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Multiplication Tables Challenge found on
    /// https://www.codeeval.com/open_challenges/23/
    /// </summary>
    class MultiplicationTables
    {
        static void Main(string[] args)
        {
            for (int factorOne = 1; factorOne <= 12; factorOne++)
            {
                StringBuilder line = new StringBuilder();

                line.Append(factorOne);

                for (int factorTwo = 2; factorTwo <= 12; factorTwo++)
                {
                    line.Append(string.Format("{0,4:####}", factorOne * factorTwo));
                }
                
                Console.WriteLine(line);
            }
        }
    }
}