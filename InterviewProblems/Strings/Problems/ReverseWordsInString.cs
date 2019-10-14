using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class ReverseWordsInString
    {
        /*
            Given an input string, reverse the string word by word.

            Example 1:

            Input: "the sky is blue"
            Output: "blue is sky the"
            Example 2:

            Input: "  hello world!  "
            Output: "world! hello"
            Explanation: Your reversed string should not contain leading or trailing spaces.
            Example 3:

            Input: "a good   example"
            Output: "example good a"
            Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
        */

        public static string ReverseWords(string s)
        {
            string[] splitWords = s.Split(' ');
            for (int i = 0, j = splitWords.Length - 1; i < splitWords.Length / 2; i++, j--)
            {
                string temp = splitWords[i];
                splitWords[i] = splitWords[j];
                splitWords[j] = temp;
            }

            StringBuilder result = new StringBuilder();
            foreach (string word in splitWords)
            {
                if (word != "")
                    result.Append(word + " ");
            }

            return result.ToString().Trim();
        }
    }
}
