using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class MostFrequentKElements
    {
        /*
        Given a non-empty array of integers, return the k most frequent elements.

        Example 1:

        Input: nums = [1,1,1,2,2,3], k = 2
        Output: [1,2]
        Example 2:

        Input: nums = [1], k = 1
        Output: [1]
        */
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == 0 || nums == null)
            {
                return null;
            }

            Dictionary<int, int> numOccur = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numOccur.ContainsKey(num))
                {
                    numOccur[num]++;
                }
                else
                {
                    numOccur.Add(num, 1);
                }
            }

            int key = 0;
            int keyCount = 0;
            int[] result = new int[k];

            for (int i = 0; i < k; i++)
            {
                foreach (int num in numOccur.Keys)
                {
                    if (numOccur[num] > keyCount)
                    {
                        keyCount = numOccur[num];
                        key = num;
                    }
                }
                numOccur.Remove(key);
                result[i] = key;
                key = 0;
                keyCount = 0;
            }

            return result;
        }
    }
}
