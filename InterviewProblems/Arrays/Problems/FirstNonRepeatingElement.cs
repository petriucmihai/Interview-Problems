using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class FirstNonRepeatingElement
    {
        // Find the first non-repeating element in a given array of integers
        public static int FindFirstNonRepeating(int[] array)
        {
            Dictionary<int, int> elementCounts = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!elementCounts.ContainsKey(array[i]))
                {
                    elementCounts.Add(array[i], 1);
                }
                else
                {
                    elementCounts[array[i]]++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (elementCounts[array[i]] == 1)
                    return array[i];
            }

            return -1;
        }
    }
}
