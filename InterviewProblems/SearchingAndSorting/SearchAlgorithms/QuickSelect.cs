using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.SearchAlgorithms
{
    class QuickSelect
    {
        /*
             Quickselect is a selection algorithm to find the k-th smallest element 
             in an unordered list. It is related to the quick sort sorting algorithm.
        */
        public static int FindKthSmallestElement(int[] arr, int k)
        {
            return QuickSelectAlg(arr, k, 0, arr.Length - 1);
        }

        private static int QuickSelectAlg(int[] arr, int k, int left, int right)
        {
            int partition = Partition(arr, left, right);

            if (partition == k)
            {
                return arr[partition];
            }
            else if (partition < k)
            {
                return QuickSelectAlg(arr, k, partition + 1, right);
            }
            else
            {
                return QuickSelectAlg(arr, k, left, partition - 1);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int idxPivot = left;

            for (int i = left; i <= right; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(arr, i, idxPivot);
                    idxPivot++;
                }
            }

            Swap(arr, idxPivot, right);

            return idxPivot;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
