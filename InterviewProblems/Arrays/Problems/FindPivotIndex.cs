using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class FindPivotIndex
    {
        /*
        Given an array of integers nums, write a method that returns the "pivot" index of this array.

        We define the pivot index as the index where the sum of the numbers to the left of the index is equal to the sum of the numbers to the right of the index.

        If no such index exists, we should return -1. If there are multiple pivot indexes, you should return the left-most pivot index.
        */
        public static int PivotIndex(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            else if (nums.Length == 1)
            {
                return 0;
            }

            int[] rightSums = new int[nums.Length];
            int[] leftSums = new int[nums.Length];

            leftSums[0] = nums[0];
            for (int i = 1; i < leftSums.Length; i++)
            {
                leftSums[i] = leftSums[i - 1] + nums[i];
            }

            int n = nums.Length;
            rightSums[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightSums[i] = rightSums[i + 1] + nums[i];
            }

            if (rightSums[1] == 0)
                return 0;

            for (int i = 1; i < n - 1; i++)
            {
                if (leftSums[i - 1] == rightSums[i + 1])
                {
                    return i;
                }
            }

            if (leftSums[n - 2] == 0)
            {
                return n - 1;
            }

            return -1;
        }
    }
}
