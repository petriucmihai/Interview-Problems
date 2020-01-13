using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class CombinationSum
    {
        /*
        Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.

        The same repeated number may be chosen from candidates unlimited number of times.

        Note:

        All numbers (including target) will be positive integers.
        The solution set must not contain duplicate combinations.
        Example 1:

        Input: candidates = [2,3,6,7], target = 7,
        A solution set is:
        [
          [7],
          [2,2,3]
        ]
        Example 2:

        Input: candidates = [2,3,5], target = 8,
        A solution set is:
        [
          [2,2,2,2],
          [2,3,3],
          [3,5]
        ]
        */
        public static IList<IList<int>> FindCombinationSum(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> current = new List<int>();

            CheckPermutations(candidates, target, 0, 0, current, result);

            return result;
        }

        private static void CheckPermutations(int[] candidates, int target, int index, int currentSum, List<int> currentList, List<IList<int>> result)
        {
            for (int i = index; i < candidates.Length; i++)
            {
                if (currentSum == target)
                {
                    List<int> addResult = new List<int>();
                    foreach (int num in currentList)
                    {
                        addResult.Add(num);
                    }
                    result.Add(addResult);
                    break;
                }
                else if (currentSum > target)
                {
                    break;
                }

                currentList.Add(candidates[i]);
                CheckPermutations(candidates, target, i, currentSum + candidates[i], currentList, result);
                currentList.RemoveAt(currentList.Count() - 1);
            }

        }
    }
}
