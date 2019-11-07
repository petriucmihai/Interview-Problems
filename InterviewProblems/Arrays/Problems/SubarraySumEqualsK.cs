using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class SubarraySumEqualsK
    {
        /*
        Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

        Example 1:
        Input:nums = [1,1,1], k = 2
        Output: 2
        */

        // Continuous sum method
        public int SubarrayContinuousSum(int[] nums, int k)
        {
            int count = 0;
            int[] sum = new int[nums.Length + 1];
            sum[0] = 0;

            for (int i = 1; i < sum.Length; i++)
            {
                sum[i] = nums[i - 1] + sum[i - 1];
            }

            for (int start = 0; start < nums.Length; start++)
            {
                for (int end = start + 1; end < sum.Length; end++)
                {
                    if (sum[end] - sum[start] == k)
                        count++;
                }
            }
            return count;
        }
    }
}
