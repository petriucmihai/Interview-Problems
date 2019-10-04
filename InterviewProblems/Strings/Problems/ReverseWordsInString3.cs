using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class ReverseWordsInString3
    {
        /*
            Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

            Example 1:
                Input: "Let's take LeetCode contest"
                Output: "s'teL ekat edoCteeL tsetnoc"

            Note: In the string, each word is separated by single space and there will not be any extra space in the string.
        */

        // Time: O(n)
        public string ReverseWords(string s)
        {
            string[] splitWord = s.Split(' ');

            for (int k = 0; k < splitWord.Count(); k++)
            {
                char[] wordArray = splitWord[k].ToCharArray();
                for (int i = 0, j = wordArray.Count() - 1; i < wordArray.Count() / 2; i++, j--)
                {
                    char temp = wordArray[j];
                    wordArray[j] = wordArray[i];
                    wordArray[i] = temp;
                }
                splitWord[k] = new string(wordArray);
            }

            StringBuilder result = new StringBuilder();
            result.Append(splitWord[0]);

            for (int i = 1; i < splitWord.Count(); i++)
            {
                result.Append(" " + splitWord[i]);
            }

            return result.ToString();
        }
    }
}
