using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class CountAndSay
    {
        /*
            The count-and-say sequence is the sequence of integers with the first five terms as following:

            1.     1
            2.     11
            3.     21
            4.     1211
            5.     111221
            1 is read off as "one 1" or 11.
            11 is read off as "two 1s" or 21.
            21 is read off as "one 2, then one 1" or 1211.

            Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence.

            Note: Each term of the sequence of integers will be represented as a string.

 

            Example 1:

            Input: 1
            Output: "1"
            Example 2:

            Input: 4
            Output: "1211"
        */

        public string ConvertToCountAndSay(int n)
        {
            string s = "1";
            for (int i = 1; i < n; i++)
            {
                StringBuilder newString = new StringBuilder();

                for (int j = 0; j < s.Length; j++)
                {
                    char curr = s[j];
                    int count = 0;
                    while (j < s.Length && s[j] == curr)
                    {
                        count++;
                        j++;
                    }
                    j--;

                    newString.Append(count.ToString());
                    newString.Append(curr.ToString());
                }
                s = newString.ToString();
            }

            return s;
        }

    }
}
