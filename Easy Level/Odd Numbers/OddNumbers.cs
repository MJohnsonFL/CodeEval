using System;

namespace OddNumbers
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Odd Numbers Challenge found on
    /// https://www.codeeval.com/open_challenges/25/
    /// </summary>
    class OddNumbers
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
                if (i % 2 != 0)
                    Console.WriteLine(i);
        }
    }
}
