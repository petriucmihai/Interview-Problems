using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class RottenOranges
    {
        /*
        In a given grid, each cell can have one of three values:

        the value 0 representing an empty cell;
        the value 1 representing a fresh orange;
        the value 2 representing a rotten orange.
        Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

        Return the minimum number of minutes that must elapse until no cell has a fresh orange.  If this is impossible, return -1 instead.
        */
        public static int OrangesRotting(int[][] grid)
        {
            int[] x = new int[] { 1, -1, 0, 0 };
            int[] y = new int[] { 0, 0, 1, -1 };

            Queue<int[]> rottenQ = new Queue<int[]>();
            int rottenOranges = 0;
            int totalOranges = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        rottenQ.Enqueue(new int[] { i, j });
                        rottenOranges++;
                    }
                    if (grid[i][j] != 0)
                    {
                        totalOranges++;
                    }
                }
            }

            if (totalOranges == rottenOranges)
            {
                return 0;
            }
            if (rottenOranges == 0)
            {
                return -1;
            }

            int minuteCount = 0;

            while (rottenQ.Count > 0)
            {
                if (rottenOranges == totalOranges)
                {
                    return minuteCount;
                }

                int size = rottenQ.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] coordinates = rottenQ.Dequeue();

                    for (int k = 0; k < x.Length; k++)
                    {
                        if (Check(coordinates[0] + x[k], coordinates[1] + y[k], grid))
                        {
                            if (grid[coordinates[0] + x[k]][coordinates[1] + y[k]] == 1)
                            {
                                grid[coordinates[0] + x[k]][coordinates[1] + y[k]] = 2;
                                rottenQ.Enqueue(new int[] { coordinates[0] + x[k], coordinates[1] + y[k] });
                                rottenOranges++;
                            }
                        }
                    }
                }
                minuteCount++;
            }
            return -1;
        }

        private static bool Check(int i, int j, int[][] grid)
        {
            return i > -1 && i < grid.Length && j > -1 && j < grid[0].Length;
        }
    }
}
