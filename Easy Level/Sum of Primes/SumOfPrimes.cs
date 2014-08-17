using System;

namespace SumOfPrimes
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Sum of Primes Challenge found on
    /// https://www.codeeval.com/open_challenges/4/
    /// </summary>
    class SumOfPrimes
    {
        static void Main(string[] args)
        {
            int numberOfPrimesDiscovered = 0;
            int sumOfPrimes = 0;
            int currentNumberToCheck = 0;

            while (numberOfPrimesDiscovered < 1000)
            {
                if (currentNumberToCheck.IsPrime())
                {
                    sumOfPrimes += currentNumberToCheck;
                    numberOfPrimesDiscovered++;
                }
                
                currentNumberToCheck++;
            }

            Console.Out.Write(sumOfPrimes);
        }
    }

    public static class ExtensionMethods
    {
        public static bool IsPrime(this int number)
        {
            if (number == 0 || number == 1)
                return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) 
                    return false;
            }

            return true;
        }
    }
}
