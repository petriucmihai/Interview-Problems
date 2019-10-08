using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class NumberOfIslands
    {
        /*
        Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting 
        adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

            Example 1:
            Input:
            11110
            11010
            11000
            00000

            Output: 1

            Example 2:
            Input:
            11000
            11000
            00100
            00011

            Output: 3
        */

        public int[] dir1 = { 0, 0, 1, -1 };
        public int[] dir2 = { 1, -1, 0, 0 };

        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (Char.GetNumericValue(grid[i][j]) == 1)
                    {
                        count++;
                        DFS(grid, i, j);
                    }
                }
            }
            return count;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            grid[i][j] = (char)2;

            for (int x = 0; x < dir1.Length; x++)
            {
                if (IsSafe(grid, i + dir1[x], j + dir2[x]))
                {
                    DFS(grid, i + dir1[x], j + dir2[x]);
                }
            }
        }

        private bool IsSafe(char[][] grid, int i, int j)
        {
            return i < grid.Length && i >= 0 && j < grid[0].Length && j >= 0 && Char.GetNumericValue(grid[i][j]) == 1;
        }

    }
}
