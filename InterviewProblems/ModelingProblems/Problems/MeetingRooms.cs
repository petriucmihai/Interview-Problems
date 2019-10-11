using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class MeetingRooms
    {
        /*
            Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.

                Example 1:

                Input: [[0, 30],[5, 10],[15, 20]]
                Output: 2
                Example 2:

                Input: [[7,10],[2,4]]
                Output: 1
        */
        public static int MinMeetingRooms(int[][] intervals)
        {
            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i][0];
                endTimes[i] = intervals[i][1];
            }

            Array.Sort(startTimes);
            Array.Sort(endTimes);

            int startPtr = 0; int endPtr = 0; int rooms = 0;

            while (startPtr < intervals.Length)
            {
                if (startTimes[startPtr] >= endTimes[endPtr])
                {
                    rooms--;
                    endPtr++;
                }

                rooms++;
                startPtr++;
            }

            return rooms;
        }
    }
}
