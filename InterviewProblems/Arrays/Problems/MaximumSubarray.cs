using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class MaximumSubarray
    {
        /*
            Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

                Example:

                Input: [-2,1,-3,4,-1,2,1,-5,4],
                Output: 6
                Explanation: [4,-1,2,1] has the largest sum = 6.
        */

        public static int MaxSubArray(int[] nums)
        {
            return MaxSubArray(nums, 0, nums.Length - 1);
        }

        private static int MaxSubArray(int[] nums, int left, int right)
        {
            if (left == right)
                return nums[left];

            int mid = (left + right) / 2;

            int leftSum = MaxSubArray(nums, left, mid);
            int rightSum = MaxSubArray(nums, mid + 1, right);
            int crossSum = CrossSum(nums, left, right, mid);

            return Math.Max(Math.Max(leftSum, rightSum), crossSum);
        }

        private static int CrossSum(int[] nums, int left, int right, int mid)
        {
            if (left == right)
                return nums[left];

            int leftSubSum = Int32.MinValue;
            int currSum = 0;
            for (int i = mid; i >= left; i--)
            {
                currSum += nums[i];
                leftSubSum = Math.Max(leftSubSum, currSum);
            }

            int rightSubSum = Int32.MinValue;
            currSum = 0;
            for (int i = mid + 1; i < right + 1; i++)
            {
                currSum += nums[i];
                rightSubSum = Math.Max(rightSubSum, currSum);
            }

            return leftSubSum + rightSubSum;
        }
    }
}
