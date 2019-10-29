using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class TrapRainWater
    {
        /*
        Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
        */
        public static int Trap(int[] height)
        {
            int total = 0;

            if (height.Count() > 2)
            {
                int[] leftMax = new int[height.Count()];
                int[] rightMax = new int[height.Count()];

                leftMax[0] = height[0];
                for (int i = 1; i < height.Count(); i++)
                {
                    leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
                }

                rightMax[height.Count() - 1] = height[height.Count() - 1];
                for (int j = height.Count() - 2; j >= 0; j--)
                {
                    rightMax[j] = Math.Max(rightMax[j + 1], height[j]);
                }

                for (int k = 0; k < height.Count(); k++)
                {
                    total += Math.Min(leftMax[k], rightMax[k]) - height[k];
                }
            }

            return total;
        }

        // Trapping rain water -- area
        /*
        Given n non-negative integers a1, a2, ..., an , where each represents a point at 
        coordinate (i, ai). n vertical lines are drawn such that the two endpoints of 
        line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis 
        forms a container, such that the container contains the most water.
         */

        // O(n^2) brute force solution
        public static int MaxArea(int[] height)
        {
            int max = -1;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int area = Math.Min(height[i], height[j]) * (j - i);

                    if (area > max)
                    {
                        max = area;
                    }

                }
            }

            return max;
        }

        // O(n) solution -- 2 pointers, one on each end
        public static int MaxAreaOptimized(int[] height)
        {
            int max = -1;
            int i = 0; int j = height.Length - 1;

            while (i < j)
            {
                int area = Math.Min(height[i], height[j]) * (j - i);
                if (area > max)
                {
                    max = area;
                }

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return max;
        }
    }
}
