using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.SearchingAndSorting.Problems
{
    class FrequencySort
    {
        /*
        Given a string, sort it in decreasing order based on the frequency of characters.

        Example 1:

        Input:
        "tree"

        Output:
        "eert"

        Explanation:
        'e' appears twice while 'r' and 't' both appear once.
        So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
        Example 2:

        Input:
        "cccaaa"

        Output:
        "cccaaa"

        Explanation:
        Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
        Note that "cacaca" is incorrect, as the same characters must be together.
        Example 3:

        Input:
        "Aabb"

        Output:
        "bbAa"

        Explanation:
        "bbaA" is also a valid answer, but "Aabb" is incorrect.
        Note that 'A' and 'a' are treated as two different characters.
        */
        public static string FrequencySortString(string s)
        {
            if (s.Length > 2)
            {
                Dictionary<char, int> numOccur = new Dictionary<char, int>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (numOccur.ContainsKey(s[i]))
                    {
                        numOccur[s[i]]++;
                    }
                    else
                    {
                        numOccur.Add(s[i], 1);
                    }
                }

                StringBuilder result = new StringBuilder();
                while (numOccur.Keys.Count() > 0)
                {
                    char maxKey = 'a';
                    int maxNum = 0;
                    foreach (char key in numOccur.Keys)
                    {
                        if (numOccur[key] > maxNum)
                        {
                            maxNum = numOccur[key];
                            maxKey = key;
                        }
                    }

                    for (int i = 0; i < numOccur[maxKey]; i++)
                    {
                        result.Append(maxKey);
                    }

                    numOccur.Remove(maxKey);
                }

                return result.ToString();
            }

            return s;
        }
    }
}
