using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.Problems
{
    class MergeSortedArrays
    {
        // When given that first array has buffer space to hold second array
        // ASK IF GIVEN LAST INDEX OF INTEGERS IN BUFFER ARRAY
        public static void MergeSortedArraysWithBuffer(int[] a, int[] b, int lastA, int lastB)
        {
            int indexA = lastA - 1;
            int indexB = lastB - 1; // b.Count() - 1;
            int indexMerged = lastA + lastB - 1;

            while (indexB >= 0)
            {
                if (indexA >= 0 && a[indexA] > b[indexB])
                {
                    a[indexMerged] = a[indexA];
                    indexA--;
                }
                else
                {
                    a[indexMerged] = b[indexB];
                    indexB--;
                }
                indexMerged--;
            }
        }

        // When merging 2 sorted arrays, like in MergeSort
        public static int[] MergeSortedArraysNoBuffer(int[] a, int[] b)
        {
            int totalCount = a.Count() + b.Count();
            int[] c = new int[totalCount];

            int i = 0; //index for a
            int j = 0; //index for b
            int k = 0; //index for c

            while (i < a.Count() && j < b.Count())
            {
                if (a[i] <= b[j])
                {
                    c[k] = a[i];
                    i++;
                }
                else
                {
                    c[k] = b[j];
                    j++;
                }
                k++;
            }

            while (i < a.Count())
            {
                c[k] = a[i];
                i++;
                k++;
            }
            while (j < b.Count())
            {
                c[k] = b[j];
                j++;
                k++;
            }

            return c;
        }
    }
}
