using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class CombinationSum
    {
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
