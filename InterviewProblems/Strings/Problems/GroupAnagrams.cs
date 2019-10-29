using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class GroupAnagrams
    {
        /*
        Given an array of strings, group anagrams together.

            Example:

            Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
            Output:
            [
              ["ate","eat","tea"],
              ["nat","tan"],
              ["bat"]
            ] 
        */
        // Categorize by sorted string solution: O(N * KlogK)
        public static IList<IList<string>> GroupAnagramsTogether(string[] strs)
        {
            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string sortedString = Sort(strs[i]);

                if (!anagrams.ContainsKey(sortedString))
                {
                    anagrams.Add(sortedString, new List<string>());
                }
                anagrams[sortedString].Add(strs[i]);
            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (string key in anagrams.Keys)
            {
                result.Add(anagrams[key]);
            }

            return result;

        }

        private static string Sort(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }

        // Can also categorize by character lengths : O(NK)
    }
}
