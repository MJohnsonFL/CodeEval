using System;
using System.IO;

namespace AgeDistribution
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Age Distribution Challenge found on
    /// https://www.codeeval.com/open_challenges/152/
    /// </summary>
    class AgeDistribution
    {

        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (!sr.EndOfStream)
                    {
                        int age = Int32.Parse(sr.ReadLine());

                        if (age == 0 || age == 1 || age == 2)
                            Console.WriteLine("Still in Mama's arms");
                        else if (age == 3 || age == 4)
                            Console.WriteLine("Preschool Maniac");
                        else if (age >= 5 && age <= 11)
                            Console.WriteLine("Elementary school");
                        else if (age == 12 || age == 13 || age == 14)
                            Console.WriteLine("Middle school");
                        else if (age >= 15 && age <= 18)
                            Console.WriteLine("High school");
                        else if (age >= 19 && age <= 22)
                            Console.WriteLine("College");
                        else if (age >= 23 && age <= 65)
                            Console.WriteLine("Working for the man");
                        else if (age >= 66 && age <= 100)
                            Console.WriteLine("The Golden Years");
                        else
                            Console.WriteLine("This program is for humans");
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
