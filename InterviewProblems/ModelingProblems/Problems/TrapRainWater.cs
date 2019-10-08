using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class TrapRainWater
    {
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
    }
}
