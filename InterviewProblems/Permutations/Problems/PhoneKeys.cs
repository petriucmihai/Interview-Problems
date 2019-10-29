using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Permutations.Problems
{
    class PhoneKeys
    {
        /*
         Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.

        Example:

        Input: "23"
        Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
        */

        public static List<string> Combinations(string digits)
        {
            string[] keys = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            List<string> result = new List<string>();

            if (digits.Length > 0)
            {
                GetCombos("", digits, keys, result);
            }
            return result;
        }

        public static void GetCombos(string currentCombo, string digitsLeft, string[] keys, List<string> result)
        {
            if (digitsLeft.Length == 0)
            {
                result.Add(currentCombo);
            }
            else
            {
                int digit = Int32.Parse(digitsLeft.Substring(0, 1));
                string letters = keys[digit];

                for (int i = 0; i < letters.Length; i++)
                {
                    string letter = keys[digit].Substring(i, 1);
                    GetCombos(currentCombo + letter, digitsLeft.Substring(1), keys, result);
                }
            }
        }
    }
}
