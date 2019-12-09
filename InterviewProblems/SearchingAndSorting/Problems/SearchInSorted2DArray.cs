using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.Problems
{
    class SearchInSorted2DArray
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }
            return BinarySearch(matrix, target, 0, (matrix.Length * matrix[0].Length) - 1);
        }

        private static bool BinarySearch(int[][] matrix, int target, int left, int right)
        {
            if (right >= left)
            {
                int mid = (left + right) / 2;
                int midRow = mid / matrix[0].Length;
                int midCol = mid % matrix[0].Length;

                if (matrix[midRow][midCol] == target)
                {
                    return true;
                }
                else if (matrix[midRow][midCol] > target)
                {
                    return BinarySearch(matrix, target, left, mid - 1);
                }
                else
                {
                    return BinarySearch(matrix, target, mid + 1, right);
                }
            }
            return false;
        }
    }
}
