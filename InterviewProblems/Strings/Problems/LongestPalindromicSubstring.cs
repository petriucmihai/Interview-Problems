using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class LongestPalindromicSubstring
    {
        /*
        Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

        Example 1:

        Input: "babad"
        Output: "bab"
        Note: "aba" is also a valid answer.
        Example 2:

        Input: "cbbd"
        Output: "bb"
        */
        public string LongestPalindrome(string s)
        {
            int longest = 0;
            int startIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int left = i;
                int right = i;

                while (left >= 0 && s[left] == s[i])
                {
                    left--;
                }
                while (right < s.Length && s[right] == s[i])
                {
                    right++;
                }

                while (left >= 0 && right < s.Length && s[right] == s[left])
                {
                    left--;
                    right++;
                }

                int currentLength = right - left - 1;

                if (longest < currentLength)
                {
                    longest = currentLength;
                    startIndex = left + 1;
                }
            }

            return s.Substring(startIndex, longest);
        }
    }
}
