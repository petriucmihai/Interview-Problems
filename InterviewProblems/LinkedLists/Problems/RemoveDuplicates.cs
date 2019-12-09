using InterviewProblems.LinkedLists.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.LinkedLists.Problems
{
    class RemoveDuplicates
    {
        // Can use external data structure
        public static void DeleteDuplicatesWithBuffer(Node head)
        {
            if (head != null)
            {
                HashSet<Node> found = new HashSet<Node>();
                found.Add(head);
                Node curr = head.next;
                Node prev = head;

                while (curr != null)
                {
                    if (found.Contains(curr))
                    {
                        prev.next = curr.next;

                    }
                    else
                    {
                        found.Add(curr);
                        prev = curr;
                    }
                    curr = curr.next;
                }
            }
        }

        // No external data structure
        public static void DeleteDuplicatesWithoutBuffer(Node head)
        {
            if (head != null)
            {
                Node curr = head.next;

                while (curr != null)
                {
                    Node temp = curr;
                    while (temp != null)
                    {
                        if (temp == curr)
                        {
                            temp.next = temp.next.next;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }
                    curr = curr.next;
                }
            }
        }

        /*
        Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        Example 1:

        Given nums = [1,1,2],

        Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

        It doesn't matter what you leave beyond the returned length.
        Example 2:

        Given nums = [0,0,1,1,1,2,2,3,3,4],

        Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

        It doesn't matter what values are set beyond the returned length.
        */
        public static int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                while (i < nums.Length - 1 && nums[i + 1] == nums[i])
                {
                    nums[i] = Int32.MaxValue;
                    i++;
                }
                count++;
            }

            int swapIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < Int32.MaxValue)
                {
                    Swap(nums, swapIndex, i);
                    swapIndex++;
                }
            }

            return count;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
