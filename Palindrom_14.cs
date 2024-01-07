using System;

namespace Setul1Ex14
{
    internal class Program
    {
        static bool IsPalindrome(int n)
        {
            string original = n.ToString(); 
            char[] charArray = original.ToCharArray(); 

            Array.Reverse(charArray); 

            string reversed = new string(charArray); 

            
            return original == reversed;
        }

        static void Main()
        {
            
            int number = 12321;

            if (IsPalindrome(number))
            {
                Console.WriteLine(number + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(number + " is not a palindrome.");
            }
        }
    }
}
