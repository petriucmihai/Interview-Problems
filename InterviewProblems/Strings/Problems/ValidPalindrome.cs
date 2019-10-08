using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class ValidPalindrome
    {
        /*
        Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.
        */

        public bool IsValidPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {

                //Check if palindrome only if mirror letters are not the same
                if (s[i] != s[s.Length - 1 - i])
                {
                    int j = s.Length - 1 - i;

                    return (CheckPalindrome(s, i + 1, j) || CheckPalindrome(s, i, j - 1));
                }
            }
            return true;
        }

        private bool CheckPalindrome(string s, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (s[i] != s[end - i + start])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
