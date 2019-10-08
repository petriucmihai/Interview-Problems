using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class ArrayElementsAreUnique
    {
        public static bool IsUnique(string input)
        {
            HashSet<char> found = new HashSet<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (found.Contains(input[i]))
                {
                    return false;
                }
                else
                {
                    found.Add(input[i]);
                }
            }
            return true;
        }
    }
}
