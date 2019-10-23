using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class SubstringInAString
    {
        // Given two strings s1 and s2, find if s2 is substring of s1. If yes, return index of first occurrence, else return -1

        // Simple solution: check s1 one-by-one for s2
        public static int isSubstring(string s1, string s2)
        {
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                if (s1[i] == s2[0])
                {
                    int j = 0;
                    while (j != s2.Length && s1[i + j] == s2[j])
                    {
                        j++;
                    }

                    if (j == s2.Length)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


    }
}
