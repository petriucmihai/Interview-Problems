using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class RearrangePositivesAndNegatives
    {
        /*
            Given an array of positive and negative numbers, arrange them such that all negative integers appear before all the positive 
            integers in the array without using any additional data structure like hash table, arrays, etc. The order of appearance should be maintained.
        */
        public static void AllNegativesFirstNotOrdered(int[] array)
        {
            // Partition process from Quicksort
            int pivot = 0; int pivotLeft = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[pivotLeft];
                    array[pivotLeft] = temp;
                    pivotLeft++;
                }
            }
        }

        /*
            Rearrange the array elements so that positive and negative numbers are placed alternatively. Number of positive and 
            negative numbers need not be equal. If there are more positive numbers they appear at the end of the array. If there 
            are more negative numbers, they too appear in the end of the array.
        */
        public static void AlternatingConstantSpace(int[] array)
        {
            // Set all negatives first and all positives after
            AllNegativesFirstNotOrdered(array);

            // Partition process from Quicksort
            int pivot = 0; int pivotLeft = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[pivotLeft];
                    array[pivotLeft] = temp;
                    pivotLeft++;
                }
            }

            // Indexes for positive and negative sections
            int idxPos = pivotLeft + 1;
            int idxNeg = 0;

            while (idxPos < array.Length && idxNeg < idxPos && array[idxNeg] < 0)
            {
                int temp = array[idxNeg];
                array[idxNeg] = array[idxPos];
                array[idxPos] = temp;
                idxPos++;
                idxNeg += 2;
            }
        }
    }
}
