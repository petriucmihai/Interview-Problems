using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.ModelingProblems.Problems
{
    class ClimbingSteps
    {
        public static int PermutationsForClimbingStepsBruteForce(int numSteps)
        {
            if (numSteps < 0)
            {
                return 0;
            }
            else if (numSteps == 0)
            {
                return 1;
            }
            else
            {
                return PermutationsForClimbingStepsBruteForce(numSteps - 1) + PermutationsForClimbingStepsBruteForce(numSteps - 2)
                    + PermutationsForClimbingStepsBruteForce(numSteps - 3);
            }
        }

        public static int PermutationsForClimbingStepsMemoization(int numSteps)
        {
            int[] memo = new int[numSteps + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }

            return PermutationsForClimbingStepsMemoization(numSteps, memo);
        }

        private static int PermutationsForClimbingStepsMemoization(int numSteps, int[] memo)
        {
            if (numSteps < 0)
            {
                return 0;
            }
            else if (numSteps == 0)
            {
                return 1;
            }
            else if (memo[numSteps] > -1)
            {
                return memo[numSteps];
            }
            else
            {
                memo[numSteps] = PermutationsForClimbingStepsMemoization(numSteps - 1, memo) +
                    PermutationsForClimbingStepsMemoization(numSteps - 2, memo) + PermutationsForClimbingStepsMemoization(numSteps - 3, memo);
                return memo[numSteps];
            }
        }
    }
}
