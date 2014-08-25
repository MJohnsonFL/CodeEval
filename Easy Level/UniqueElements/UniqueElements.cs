using System;
using System.IO;
using System.Collections.Generic;

namespace UniqueElements
{


    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Unique Elements Challenge found on
    /// https://www.codeeval.com/open_challenges/29/
    /// </summary>
    class UniqueElements
    {
        public static string RemoveDupesAndSort(string[] line)
        {
            List<int> intList = new List<int>();

            foreach (string s in line)
            {
                int i = Int32.Parse(s);
                if (!intList.Contains(i))
                    intList.Add(i);
            }

            intList.Sort();

            return string.Join(",", intList);
        }
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        Console.WriteLine(RemoveDupesAndSort(line));
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
