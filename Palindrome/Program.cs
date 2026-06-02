using System;
using System.Linq;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string word in args)
            {
                bool result = IsPalindrome(word);
                Console.WriteLine($"{word} -> {result.ToString().ToLower()}");
            }
        }

        public static bool IsPalindrome(string s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            
            if (s.Length < 2)
                return true;
            
            bool Check(int left, int right)
            {
                while (left < right)
                {
                    if (s[left] != s[right])
                        return false;

                    left++;
                    right--;
                }
                return true;
            }
            return Check(0, s.Length - 1);
        }
    }
}
