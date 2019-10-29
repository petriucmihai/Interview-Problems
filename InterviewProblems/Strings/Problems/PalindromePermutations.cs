using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class PalindromePermutations
    {
        /*
        Given a string, determine if a permutation of the string could form a palindrome. 
        */
        public static bool CanPermutePalindrome(string s)
        {
            // Create dictionary -- count occurrences of each letter. 
            // If there are more than 1 letters with odd occurrences, no palindrome permutations
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (occurrences.ContainsKey(s[i]))
                {
                    occurrences[s[i]]++;
                }
                else
                {
                    occurrences.Add(s[i], 1);
                }
            }

            int oddCount = 0;

            foreach (char letter in occurrences.Keys)
            {
                if (occurrences[letter] % 2 != 0)
                    oddCount++;

                if (oddCount > 1)
                    return false;
            }

            return oddCount <= 1;
        }

        /*
        Given a string s, return all the palindromic permutations (without duplicates) of it. Return an empty list if no palindromic permutation could be form.

            Example 1:

            Input: "aabb"
            Output: ["abba", "baab"]
            Example 2:

            Input: "abc"
            Output: []
        */
        public static List<string> GeneratePalindromes(string s)
        {
            List<string> result = new List<string>();
            // Use previous code to check if the string can be permuted into a palindrome
            if (CanPermutePalindrome(s))
            {

            }

            return result;
        }
    }
}
