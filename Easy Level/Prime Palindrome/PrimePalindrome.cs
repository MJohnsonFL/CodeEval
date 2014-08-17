using System;
using System.Linq;

namespace PrimePalindrome
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Prime Palindrome Challenge found on
    /// https://www.codeeval.com/open_challenges/3/
    /// </summary>
    class PrimePalindrome
    {
        static void Main(string[] args)
        {
            int number = 1000;
            bool foundPalindrome = false;

            while (foundPalindrome == false)
            {
                if (number.IsPrime() && number.IsPalindrome())
                    foundPalindrome = true;
                else
                    number--;
            }

            Console.Write(number);
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

        public static bool IsPalindrome(this int number)
        {
            char[] numberAsCharArray = number.ToString().ToCharArray();
            Array.Reverse(numberAsCharArray);
            string s = new string(numberAsCharArray);
            if (s == number.ToString())
                return true;
            return false;
        }
    }
}
