using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.SearchAlgorithms
{
    class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            return Search(arr, target, 0, arr.Length - 1);
        }

        private static int Search(int[] arr, int target, int left, int right)
        {
            if (right >= left)
            {
                int mid = (right + left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    return Search(arr, target, left, mid - 1);
                }
                else
                {
                    return Search(arr, target, mid + 1, right);
                }
            }
            return -1;
        }
    }
}
