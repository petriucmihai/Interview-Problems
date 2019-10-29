using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class MergeOverlappingIntervals
    {
        /*
        Given a collection of intervals, merge all overlapping intervals.

        Example 1:

        Input: [[1,3],[2,6],[8,10],[15,18]]
        Output: [[1,6],[8,10],[15,18]]
        Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
        Example 2:

        Input: [[1,4],[4,5]]
        Output: [[1,5]]
        Explanation: Intervals [1,4] and [4,5] are considered overlapping.
         */
        public int[][] Merge(int[][] intervals)
        {
            intervals = intervals.OrderBy(entry => entry[0]).ToArray();

            List<int[]> result = new List<int[]>();
            int i = 0;
            while (i < intervals.Length)
            {
                int start = intervals[i][0];
                int max = intervals[i][1];

                while (i < intervals.Length && intervals[i][0] <= max)
                {
                    if (intervals[i][1] >= max)
                    {
                        max = intervals[i][1];
                    }
                    i++;
                }
                result.Add(new int[] { start, max });
            }

            int[][] returnIntervals = new int[result.Count()][];
            for (int j = 0; j < returnIntervals.Length; j++)
            {
                returnIntervals[j] = result[j];
            }

            return returnIntervals;
        }
    }
}
