using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class TwoSum
    {
        /*
         *  Given an array of integers, return indices of the two numbers such that they add up to a specific target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

            Example:

            Given nums = [2, 7, 11, 15], target = 9,

            Because nums[0] + nums[1] = 2 + 7 = 9,
            return [0, 1].
        */


        // Time: O(n^2), Space: O(1)
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new ArgumentException("No elements create target sum");
        }

        // Time: O(n), Space: O(n)
        public static int[] TwoSumWithDict(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }

                if (!numDict.ContainsKey(nums[i]))
                    numDict.Add(nums[i], i);

            }

            throw new ArgumentException("No elements create target sum");
        }
    }
}
