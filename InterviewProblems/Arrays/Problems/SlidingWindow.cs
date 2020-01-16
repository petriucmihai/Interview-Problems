using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class SlidingWindow
    {
        /*
        Given an array of integers of size ‘n’.
        Our aim is to calculate the maximum sum of ‘k’ 
        consecutive elements in the array.

        Input  : arr[] = {100, 200, 300, 400}
                 k = 2
        Output : 700

        Input  : arr[] = {1, 4, 2, 10, 23, 3, 1, 0, 20}
                 k = 4 
        Output : 39
        We get maximum sum by adding subarray {4, 2, 10, 23}
        of size 4.

        Input  : arr[] = {2, 3}
                 k = 3
        Output : Invalid
        There is no subarray of size 3 as size of whole
        array is 2.
        */
        public static int MaxConsecutiveSumOfKElements(int[] arr, int k)
        {
            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                maxSum += arr[i];
            }

            int windowSum = maxSum;

            for (int i = k; i < arr.Length; i++)
            {
                windowSum += arr[i] - arr[i - k];

                if (windowSum > maxSum)
                {
                    maxSum = windowSum;
                }
            }

            return maxSum;
        }
    }
}
