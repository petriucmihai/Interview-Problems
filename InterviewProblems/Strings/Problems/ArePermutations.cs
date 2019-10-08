using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class ArePermutations
    {
        public static bool IsPermutation(string a, string b)
        {
            char[] array = a.ToCharArray();
            Array.Sort(array);
            string sortedA = new string(array);

            if (sortedA == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
