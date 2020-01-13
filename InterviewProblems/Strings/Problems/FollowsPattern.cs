using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class FollowsPattern
    {
        /*
        Given a pattern and a string str, find if str follows the same pattern.

        Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.

        Example 1:

        Input: pattern = "abba", str = "dog cat cat dog"
        Output: true
        Example 2:

        Input:pattern = "abba", str = "dog cat cat fish"
        Output: false
        Example 3:

        Input: pattern = "aaaa", str = "dog cat cat dog"
        Output: false
        Example 4:

        Input: pattern = "abba", str = "dog dog dog dog"
        Output: false
        */
        public static bool WordPattern(string pattern, string str)
        {
            string[] words = str.Split(' ');

            if (pattern.Length != words.Length)
            {
                return false;
            }

            Dictionary<char, string> relations = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char patternLetter = pattern[i];
                string stringWord = words[i];

                if (relations.ContainsKey(patternLetter))
                {
                    if (relations[patternLetter] != stringWord)
                    {
                        return false;
                    }
                }
                else if (relations.ContainsValue(stringWord))
                {
                    return false;
                }
                else
                {
                    relations.Add(patternLetter, stringWord);
                }
            }

            return true;
        }
    }
}
