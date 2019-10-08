using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.SortingAlgorithms
{
    class QuickSort
    {
        public static void QuickSortInt(int[] arr)
        {
            QuickSortInt(arr, 0, arr.Length - 1);
        }

        private static void QuickSortInt(int[] arr, int left, int right)
        {
            if (right > left)
            {
                int partition = Partition(arr, left, right);
                QuickSortInt(arr, left, partition - 1);
                QuickSortInt(arr, partition + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, j, i);
                }
            }

            Swap(arr, i + 1, right);

            return i + 1;
        }

        private static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
