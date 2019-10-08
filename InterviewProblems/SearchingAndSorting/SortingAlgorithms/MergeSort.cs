using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.SortingAlgorithms
{
    class MergeSort
    {
        public static void MergeSortInt(int[] arr)
        {
            MergeSortInt(arr, 0, arr.Length - 1);
        }

        private static void MergeSortInt(int[] arr, int left, int right)
        {
            if (right > left)
            {
                int mid = (right + left) / 2;

                MergeSortInt(arr, left, mid);
                MergeSortInt(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] leftArr = new int[mid - left + 1];
            int[] rightArr = new int[right - mid];

            for (int x = 0; x < leftArr.Length; x++)
            {
                leftArr[x] = arr[left + x];
            }
            for (int x = 0; x < rightArr.Length; x++)
            {
                rightArr[x] = arr[mid + 1 + x];
            }

            int i = 0; int j = 0; int k = left;

            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] < rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }
            while (i < leftArr.Length)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < rightArr.Length)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
