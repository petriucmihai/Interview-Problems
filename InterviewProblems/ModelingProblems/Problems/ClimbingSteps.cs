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

        /*
        You are climbing a stair case. It takes n steps to reach to the top.

        Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

        Note: Given n will be a positive integer.

        Example 1:

        Input: 2
        Output: 2
        Explanation: There are two ways to climb to the top.
        1. 1 step + 1 step
        2. 2 steps
        Example 2:

        Input: 3
        Output: 3
        Explanation: There are three ways to climb to the top.
        1. 1 step + 1 step + 1 step
        2. 1 step + 2 steps
        3. 2 steps + 1 step
         */

        // Brute force: O(2^n)
        public int ClimbStairs(int n)
        {
            return Climb(0, n);
        }

        private int Climb(int i, int n)
        {
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }

            return Climb(i + 1, n) + Climb(i + 2, n);
        }

        // Solution with memoization
        public int ClimbStairs(int n)
        {
            int[] memo = new int[n + 1];
            return Climb(0, n, memo);
        }

        private int Climb(int i, int n, int[] memo)
        {
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }
            if (memo[i] > 0)
            {
                return memo[i];
            }

            memo[i] = Climb(i + 1, n, memo) + Climb(i + 2, n, memo);

            return memo[i];
        }


        public int MinCostClimbingStairs(int[] cost)
        {
            int[] memo = new int[cost.Length + 1];
            return Math.Min(FindCost(0, cost.Length - 1, cost, memo), FindCost(1, cost.Length - 1, cost, memo));
        }

        /*
        On a staircase, the i-th step has some non-negative cost cost[i] assigned (0 indexed).

        Once you pay the cost, you can either climb one or two steps. You need to find minimum cost to reach the top of the floor, and you can either start from the step with index 0, or the step with index 1.

        Example 1:
        Input: cost = [10, 15, 20]
        Output: 15
        Explanation: Cheapest is start on cost[1], pay that cost and go to the top.
        Example 2:
        Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
        Output: 6
        Explanation: Cheapest is start on cost[0], and only step on 1s, skipping cost[3].
         */

        private int FindCost(int i, int n, int[] cost, int[] memo)
        {
            if (i > n)
            {
                return Int32.MaxValue;
            }
            if (i == n)
            {
                return cost[n];
            }
            if (i == n - 1)
            {
                return cost[n - 1];
            }
            if (memo[i] > 0)
            {
                return memo[i];
            }

            memo[i] = cost[i] + Math.Min(FindCost(i + 1, n, cost, memo), FindCost(i + 2, n, cost, memo));
            return memo[i];
        }
    }
}
