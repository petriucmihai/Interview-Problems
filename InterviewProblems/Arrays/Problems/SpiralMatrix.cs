
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class SpiralMatrix
    {
        /*
        Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

        Example 1:

        Input:
        [
         [ 1, 2, 3 ],
         [ 4, 5, 6 ],
         [ 7, 8, 9 ]
        ]
        Output: [1,2,3,6,9,8,7,4,5]
        
        Example 2:

        Input:
        [
          [1, 2, 3, 4],
          [5, 6, 7, 8],
          [9,10,11,12]
        ]
        Output: [1,2,3,4,8,12,11,10,9,5,6,7]
        */

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();

            if (matrix == null || matrix.Length == 0)
                return result;

            int endRow = matrix.Length;
            int endCol = matrix[0].Length;

            int startRow = 0;
            int startCol = 0;
            int i = 0;

            while (startRow < endRow && startCol < endCol)
            {
                for (i = startCol; i < endCol; i++)
                {
                    result.Add(matrix[startRow][i]);
                }
                startRow++;

                for (i = startRow; i < endRow; i++)
                {
                    result.Add(matrix[i][endCol - 1]);
                }
                endCol--;

                if (startRow < endRow)
                {
                    for (i = endCol - 1; i >= startCol; i--)
                    {
                        result.Add(matrix[endRow - 1][i]);
                    }
                    endRow--;
                }

                if (startCol < endCol)
                {
                    for (i = endRow - 1; i >= startRow; i--)
                    {
                        result.Add(matrix[i][startCol]);
                    }
                    startCol++;
                }
            }
            return result;
        }
    }
}
