using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class ProductOfArrayWithoutSelf
    {
        /*
        Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to 
        the product of all the elements of nums except nums[i].

            Example:
            Input:  [1,2,3,4]
            Output: [24,12,8,6]

        */

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] output = new int[nums.Length];
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];

            left[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }

            right[nums.Length - 1] = 1;
            for (int j = nums.Length - 2; j >= 0; j--)
            {
                right[j] = right[j + 1] * nums[j + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = left[i] * right[i];
            }

            return output;
        }
    }
}
