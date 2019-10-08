using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class ReverseString
    {
        public void ReverseWholeString(char[] s)
        {
            int i = 0;
            int j = s.Count() - 1;
            for (i = 0; i < s.Count() / 2; i++, j--)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
