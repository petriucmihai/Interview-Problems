using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays.Problems
{
    class ThreeSum
    {
        /*
            Given an array nums of n integers, are there elements a, b, c 
            in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero. 
        */

        // THIS CODE EXCEEDS TIME LIMIT ON LEETCODE
        public static IList<IList<int>> Sum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int current = nums[i];
                HashSet<int> numList = new HashSet<int>();

                for (int j = i + 1; j < nums.Length; j++)
                {
                    int complement = 0 - current - nums[j];
                    if (numList.Contains(complement))
                    {
                        List<int> sum = new List<int> { current, nums[j], complement };

                        sum.Sort();

                        bool add = true;
                        foreach (List<int> list in result)
                        {
                            if (list.SequenceEqual(sum))
                            {
                                add = false;
                            }
                        }

                        if (add)
                            result.Add(sum);
                    }
                    else
                    {
                        numList.Add(nums[j]);
                    }
                }
            }
            return result;
        }
    }
}
