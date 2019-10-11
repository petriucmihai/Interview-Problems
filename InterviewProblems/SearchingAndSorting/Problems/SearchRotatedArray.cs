using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.Problems
{
    class SearchRotatedArray
    {
        /*
            Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
            (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

            You are given a target value to search. If found in the array return its index, otherwise return -1.

            You may assume no duplicate exists in the array.

            Your algorithm's runtime complexity must be in the order of O(log n).

                Example 1:

                Input: nums = [4,5,6,7,0,1,2], target = 0
                Output: 4
                Example 2:

                Input: nums = [4,5,6,7,0,1,2], target = 3
                Output: -1 
        */
        public static int Search(int[] nums, int target) {
            int pivot = FindRotateIndex(nums, 0, nums.Length - 1);

            if (pivot == -1)
                return BinarySearch(nums, 0, nums.Length - 1, target);

            if (nums[pivot] == target)
                return pivot;

            if (target < nums[0])
                return BinarySearch(nums, pivot, nums.Length - 1, target);

            return BinarySearch(nums, 0, pivot, target);
        }

        private static int FindRotateIndex(int[] nums, int left, int right) {
            if (right < left)
                return -1;
            if (right == left)
                return left;

            int pivot = (left + right) / 2;

            if (nums[pivot] > nums[pivot + 1])
            {
                return pivot + 1;
            }
            else if (nums[pivot] < nums[left])
            {
                return FindRotateIndex(nums, left, pivot - 1);
            }
            else
            {
                return FindRotateIndex(nums, pivot + 1, right);
            }
        }

        private static int BinarySearch(int[] nums, int left, int right, int target) {
            if (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    return BinarySearch(nums, left, mid - 1, target);
                }
                else
                {
                    return BinarySearch(nums, mid + 1, right, target);
                }
            }

            return -1;
        }
    }
}
